using SmartphoneFactory.Interfaces;
using SmartphoneFactory.Smartphones;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Factories
{
    internal class Abstract : IPhoneFactory
    {
        private readonly string _name;
        private readonly int _weight;
        private readonly double _screentSize;
        private readonly string _cpu;
        private readonly int _ram;
        private readonly int _storage;
        private readonly int _battery;
        private readonly int _camera;

        public Abstract(string name,
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
 
        public ISmartphone GetSmartphone()
            => new AbstractPhone(
                _name,
                _weight,
                _screentSize,
                _cpu,
                _ram,
                _storage,
                _battery,
                _camera);
    }
}
