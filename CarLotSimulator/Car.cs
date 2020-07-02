using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            Carlot.numberOfCars++;
        }

        public Car(string driver,
            int year,
                        string make,
                        string model,
                        string engineNoise,
                        string honkNoise,
                        bool isDriveable)
        {
            Driver = driver;
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            Carlot.numberOfCars++;
        }
        public string Driver { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        { 
            Console.WriteLine(honkNoise);
        }
    }
}
