﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReflector.Properties;

namespace WpfReflector
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ =  new App()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
