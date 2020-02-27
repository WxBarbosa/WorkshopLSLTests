using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLSLTests.Domain.Interfaces
{
    public interface ICar
    {
        void AddColor(string color);
        bool TurnOn();
        bool TurnOff();
        void Driving();
        bool IsDrivingCar();
        void StopDrivingCar();
    }
}
