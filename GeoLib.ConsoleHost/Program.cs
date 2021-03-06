﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GeoLib.Services;

namespace GeoLib.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostGeoManager = new ServiceHost(typeof(GeoManager));
            hostGeoManager.Open();

            Console.WriteLine("Services started. Press [Enter] to close the service");
            Console.ReadLine();

            hostGeoManager.Close();
        }
    }
}
