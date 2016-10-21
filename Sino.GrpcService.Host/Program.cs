using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Sino.GrpcService.Impl;
using System;
using System.IO;

namespace Sino.GrpcService.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string envName = string.Empty;
            var builder = new ConfigurationBuilder();
            var provider = new EnvironmentVariablesConfigurationProvider();
            provider.Load();
            if(!provider.TryGet("EnvName", out envName))
            {
                envName = "debug";
            }

            if (args != null && args.Length > 0)
                envName = args[0];

            var config = builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .AddJsonFile($"appSettings.{envName}.json")
                .Build();

            Console.WriteLine("service start");
            RpcConfiguration.Start(config);
            RpcConfiguration.Stop();
        }
    }
}
