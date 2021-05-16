using SmartphoneFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Smartphones
{
    public class P30Pro : ISmartphone
    {
        public string Name => "P30 Pro";

        public int Weight => 192;

        public double ScreenSize => 6.47;

        public string CPU => "Kirin 980";

        public int RAM => 8;

        public int Storage => 512;

        public int Battery => 4200;

        public int Camera => 32;
    }
}
