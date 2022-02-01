using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string Petname { get; set; }
        private bool carIsDead;

        public Car()
        {

        }

        public Car(string name, int maxSp, int curSp)
        {
            Petname = name;
            MaxSpeed = maxSp;
            CurrentSpeed = curSp;
        }

        public delegate void CarEngineHandler(string message);
        private CarEngineHandler listHandlers;

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listHandlers != null)
                {
                    listHandlers("Sorry this car is dead...");
                }
            }
            else
            {
                CurrentSpeed += delta;

                if (
                    10 <= (MaxSpeed - CurrentSpeed) &&
                    0 >= (MaxSpeed - CurrentSpeed) &&
                    listHandlers != null
                    )
                {
                    listHandlers("Careful buggy! Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    listHandlers($"Engine is dead. Current speed: {CurrentSpeed}");
                }
                else
                {
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
    }
}
