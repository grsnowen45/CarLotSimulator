using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carlot = new Carlot();
            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property            



            //DONE Now that the Car class is created we can instanciate 3 new cars
            //DONE Set the properties for each of the cars
            //DONE Call each of the methods for each car

            Console.WriteLine($"Number of Cars created: {Carlot.numberOfCars}");

            var myCar = new Car();

            myCar.Driver = "Graybles";
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2008;
            myCar.EngineNoise = "vroom vroom";
            myCar.HonkNoise = "beep beep";
            myCar.IsDriveable = true;
        
        
            Console.WriteLine($"Number of Cars created: {Carlot.numberOfCars}");

            var stevosCar = new Car()
            {
                Driver = "StevO!",
                Year = 2020,
                Make = "Tonka",
                Model = "Super Truck",
                EngineNoise = "boom boom",
                HonkNoise = "caw caw",
                IsDriveable = false
            };

            Console.WriteLine($"Number of Cars created: {Carlot.numberOfCars}");

            var jakesCar = new Car("Jake", 2001, "Ford", "Focus", "skrrrrrt", "boop boop", true);

            Console.WriteLine($"Number of Cars created: {Carlot.numberOfCars}");

            var jebsCar = new Car()
            {
                Driver = "J3BBY M@N3",
                Year = 3000,
                Make = "Mars",
                Model = "Rover Rumbler",
                EngineNoise = "bleep blorp",
                HonkNoise = "Zing Zoooop!!",
                IsDriveable = true
                
                
            };

            Console.WriteLine($"Number of Cars created: {Carlot.numberOfCars}");


            myCar.MakeEngineNoise(myCar.EngineNoise);

            myCar.MakeHonkNoise(myCar.HonkNoise);

            jakesCar.MakeEngineNoise(jakesCar.EngineNoise);

            jakesCar.MakeHonkNoise(jakesCar.HonkNoise);

            stevosCar.MakeEngineNoise(stevosCar.EngineNoise);

            stevosCar.MakeHonkNoise(stevosCar.HonkNoise);

            jebsCar.MakeEngineNoise(jebsCar.EngineNoise);

            jebsCar.MakeHonkNoise(jebsCar.HonkNoise);





            //*************BONUS*************//

            //DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            carlot.carList.Add(myCar);
            carlot.carList.Add(stevosCar);
            carlot.carList.Add(jakesCar);
            carlot.carList.Add(jebsCar);
            

            foreach(var Car in carlot.carList)
            {
                Console.WriteLine($"Driver: {Car.Driver} Year: {Car.Year} Make: {Car.Make} Model: {Car.Model}");
            }
            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            //DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
