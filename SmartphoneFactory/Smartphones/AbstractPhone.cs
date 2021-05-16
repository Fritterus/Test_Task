using SmartphoneFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Smartphones
{
    internal class AbstractPhone : ISmartphone
    {
        private readonly string _name;
        private readonly int _weight;
        private readonly double _screentSize;
        private readonly string _cpu;
        private readonly int _ram;
        private readonly int _storage;
        private readonly int _battery;
        private readonly int _camera;

        public AbstractPhone(string name,
                             int weight,
                             double screentSize,
                             string cpu,
                             int ram,
                             int storage,
                             int battery,
                             int camera)
        {
            _name = name;
            _weight = weight;
            _screentSize = screentSize;
            _cpu = cpu;
            _ram = ram;
            _storage = storage;
            _battery = battery;
            _camera = camera;
        }

        public string Name => _name;
        public int Weight => _weight;
        public double ScreenSize => _screentSize;
        public string CPU => _cpu;
        public int RAM => _ram;
        public int Storage => _storage;
        public int Battery => _battery;
        public int Camera => _camera;
    }
}
