using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
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
        public event CarEngineHandler AboutToBlow;
        public event CarEngineHandler Exploded;
        public event CarEngineHandler Info;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Exploded?.Invoke("Sorry this car is dead...");
             }
            else
            {
                CurrentSpeed += delta;

                if (10 >= (MaxSpeed - CurrentSpeed) && 0 <= (MaxSpeed - CurrentSpeed))
                {
                    AboutToBlow?.Invoke("Careful buggy! Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    Exploded?.Invoke($"Engine is dead. Current speed: {CurrentSpeed}");
                }
                else
                {
                    Info?.Invoke($"CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
    }
}
