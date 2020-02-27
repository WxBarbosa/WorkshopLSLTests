using System;
using System.Collections.Generic;
using System.Text;
using WorkshopLSLTests.Domain.Interfaces;

namespace WorkshopLSLTests.Domain.Entities
{
    public class Car : ICar
    {
        private string Color { get; set; }
        private bool On { get; set; }
        private bool IsDriving { get; set; }

        public void AddColor(string color) => this.Color = color;

        public void Driving()
        {
            if(this.On)
                this.IsDriving = true;
        }

        public void StopDrivingCar()
        {
            if (!this.On)
                throw new InvalidOperationException("O carro deve está ligado.");
            else
            {
                this.IsDriving = false;
            }
        }

        public bool IsDrivingCar()
        {
            return this.IsDriving;
        }

        public bool TurnOff()
        {
            this.On = false;
            return this.On;
        }

        public bool TurnOn()
        {
            this.On = true;
            return this.On;
        }
    }
}
