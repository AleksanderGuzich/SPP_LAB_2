using System;
using System.Collections.Generic;
using System.IO;
using ConsoleApp.UsageClasses;
using FakerLib;
using FakerLib.Impl;

namespace ConsoleApp
{
    internal static class Program
    {
        private static readonly string PluginPath = "C:/Users/Xiaomi/Desktop/СПП лабы/LAB_2 (faker)/GeneratorsLib/bin/Debug/net5.0/GeneratorsLib.dll";

        private const int SuccessCode = 0;

        static void Main(string[] args)
        {
            Dictionary<Type, string> plugins = new();
            plugins.Add(typeof(string), PluginPath);
            
            var f = new Faker(plugins);
            A a;
            B b;
            try
            {
                a = f.Create<A>();
                b = f.Create<B>();
            }
            catch (FakerCoreException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(SuccessCode);
        }
    }
}