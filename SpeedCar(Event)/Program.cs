using System;

namespace SpeedCar_Event_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSpeed vehicle = new CarSpeed(CarType.Otomobile);

            for (int i = 0; i < 180; i = i +20)
            {
                vehicle.CheckControlSpeed(i);
            }
        }
    }
}
