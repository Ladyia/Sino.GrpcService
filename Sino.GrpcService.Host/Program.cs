using Microsoft.Extensions.Configuration;
using Sino.GrpcService.Impl;
using System;
using System.IO;

namespace Sino.GrpcService.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            var envName = "debug";
            if (args != null && args.Length > 0)
                envName = args[0];

            var config = builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .AddJsonFile($"appSettings.{envName}.json")
                .Build();

            RpcConfiguration.Start(config);
            Console.WriteLine("service start");
            Console.ReadKey();
            RpcConfiguration.Stop();
        }
    }
}
