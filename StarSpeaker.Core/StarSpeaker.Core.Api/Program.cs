// -----------------------------------------------------------------------------------------------
// Copyright (C) Fiqri Ismail 
// Created just for fun for learning purposes of "The Standard" 
// The Standard: https://github.com/hassanhabib/The-Standard
// -----------------------------------------------------------------------------------------------


using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace StarSpeaker.Core.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
