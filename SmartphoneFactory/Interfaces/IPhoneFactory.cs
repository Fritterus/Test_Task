using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactory.Interfaces
{
    internal interface IPhoneFactory
    {
        ISmartphone GetSmartphone();
    }
}
