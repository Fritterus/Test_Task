using SmartphoneFactory.Interfaces;
using SmartphoneFactory.Smartphones;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Factories
{
    internal class Huawei : IPhoneFactory
    {
        public ISmartphone GetSmartphone()
        {
            return new P30Pro();
        }
    }
}
