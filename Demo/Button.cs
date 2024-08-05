using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    interface ButtonServer
    {
        void turnOn();
        void turnOff();
    }
    internal class Button
    {
        ButtonServer device;
        public Button(ButtonServer device)
        {
            this.device = device;
        }
    }
    internal class Lamp : ButtonServer
    {
        public void turnOff()
        {
        }

        public void turnOn()
        {
        }
    }
}
