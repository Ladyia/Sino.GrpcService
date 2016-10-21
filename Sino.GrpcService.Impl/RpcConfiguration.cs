using Autofac;
using Grpc.Core;
using Microsoft.Extensions.Configuration;
using Sino.GrpcService.Repositories;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Sino.GrpcService.Impl
{
    public static class RpcConfiguration
    {
        private static Server _server;
        private static IContainer _container;

        public static void Start(IConfigurationRoot config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(config).As<IConfigurationRoot>();
            builder.RegisterInstance(new DataContext(config)).As<IDataContext>();
            builder.RegisterAssemblyTypes(typeof(IDataContext).GetTypeInfo().Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();

            _container = builder.Build();
            var servercert = File.ReadAllText(@"G:\\ssl\\server.crt");
            var serverkey = File.ReadAllText(@"G:\\ssl\\server.key");
            var keypair = new KeyCertificatePair(servercert, serverkey);
            var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair>() { keypair });
            _server = new Server
            {
                Services = { MsgService.BindService(new MsgServiceImpl(_container.Resolve<IMsgRepository>())) },
                Ports = { new ServerPort("0.0.0.0", 9007, sslCredentials) }
            };
            _server.Start();
        }

        public static void Stop()
        {
            _server?.ShutdownAsync().Wait();
        }
    }
}
