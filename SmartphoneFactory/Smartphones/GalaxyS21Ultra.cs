using SmartphoneFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Smartphones
{
    public class GalaxyS21Ultra : ISmartphone
    {
        public string Name => "Galaxy S21 Ultra";

        public int Weight => 227;

        public double ScreenSize => 6.8;

        public string CPU => "Exynos 2100";

        public int RAM => 16;

        public int Storage => 512;

        public int Battery => 5000;

        public int Camera => 40;
    }
}
