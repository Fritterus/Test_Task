using SmartphoneFactory.Interfaces;

namespace SmartphoneFactory.Smartphones
{
    public class FindX3Pro : ISmartphone
    {
        public string Name => "Find X3 Pro";

        public int Weight => 193;

        public double ScreenSize => 6.7;

        public string CPU => "Snapdragon 888";

        public int RAM => 12;

        public int Storage => 256;

        public int Battery => 4500;

        public int Camera => 32;
    }
}
