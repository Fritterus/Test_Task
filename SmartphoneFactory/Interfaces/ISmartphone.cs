using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Interfaces
{
    internal interface ISmartphone
    {
        public string Name { get; }
        public int Weight { get; }
        public double ScreenSize { get; }
        public string CPU { get; }
        public int RAM { get; }
        public int Storage { get; }
        public int Battery { get; }
        public int Camera { get; }
    }
}
