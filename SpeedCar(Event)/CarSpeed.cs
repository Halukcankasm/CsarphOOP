using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedCar_Event_
{
    internal delegate void DlgSpeed(int intaceSpeed);
    public class CarSpeed
    {
        private event DlgSpeed SpeedEvent;
        private int speed;
        public CarType VehicleType { get; set; }
        public DateTime Time 
        {
            get 
            {
                return DateTime.Now;
            }
        }

        public int MaxSpeed 
        {
            
            get
            {
                switch (VehicleType)
                {
                    case CarType.Truck:
                        speed = 80;
                        break;
                    case CarType.Otomobile:
                        speed = 110;
                        break;
                    case CarType.MotorCar:
                        speed = 120;
                        break;
                    default:
                        speed = 100;
                        break;
                }
                return speed;
            }
        }

        public CarSpeed(CarType carType)
        {
            VehicleType = carType;
            SpeedEvent += new DlgSpeed(ControlSpeed);
            Console.WriteLine("Car type:" + VehicleType.ToString());
        }


        public void CheckControlSpeed(int instanceSpeed)
        {
            if (instanceSpeed > MaxSpeed)
            {
                if (SpeedEvent != null)
                {
                    this.SpeedEvent.Invoke(instanceSpeed);
                }
                
            }
            else
            {
                Console.WriteLine($"Speed : {instanceSpeed} , Time:{Time}");
            }
        }

        internal void ControlSpeed(int instanceSpeed)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your Speed: {instanceSpeed}, please slowly");
            Console.ResetColor();
        }
    }
}
