using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class AccubatteryController
    {
        private Accubattery accubattery;
        private OnPowerChanged callbackOnPowerChanged;

        public AccubatteryController(OnPowerChanged callbackOnPowerChanged)
        {
            this.accubattery = new Accubattery(12);
            this.callbackOnPowerChanged = callbackOnPowerChanged;
        }

        public bool accubatterryIsOn()
        {
            return this.accubattery.isOn();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
            this.callbackOnPowerChanged.onPowerChangedStatus("ON", "power is on");
        }
        public void turnOff()
        {
            this.accubattery.turnOff();
            this.callbackOnPowerChanged.onPowerChangedStatus("OFF", "power is off");
        }
    }

    interface OnPowerChanged
    {

        void onPowerChangedStatus(string value, string message);
    }
}
