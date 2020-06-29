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

            var myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2008;
            myCar.EngineNoise = "vroom vroom";
            myCar.HonkNoise = "beep beep";
            myCar.IsDriveable = true;


            var stevosCar = new Car()
            {
                Year = 2020,
                Make = "Tonka",
                Model = "Super Truck",
                EngineNoise = "boom boom",
                HonkNoise = "caw caw",
                IsDriveable = false
            };

            var jakesCar = new Car(2001, "Ford", "Focus", "skrrrrrt", "boop boop", true);


            myCar.MakeEngineNoise(myCar.EngineNoise);

            stevosCar.MakeEngineNoise(stevosCar.EngineNoise);

            jakesCar.MakeEngineNoise(jakesCar.EngineNoise);

            myCar.MakeHonkNoise(myCar.HonkNoise);

            stevosCar.MakeHonkNoise(stevosCar.HonkNoise);

            jakesCar.MakeHonkNoise(jakesCar.HonkNoise);





            //*************BONUS*************//

            //DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            carlot.carList.Add(myCar);
            carlot.carList.Add(stevosCar);
            carlot.carList.Add(jakesCar);


            foreach(var Car in carlot.carList)
            {
                Console.WriteLine($"Year: {Car.Year} Make: {Car.Make} Model: {Car.Model}");
            }
            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            //DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
