using System;

namespace OOPlab1 {
    class Program {
        static void Main(string[] args) {
            Animal dog = new Animal(10.0);

            dog.Name = "Szarik";

            dog.Feed(2.0);

            string text = dog.ReturnSpeciesAndName();
            Console.WriteLine(text);
            text += " afawefawfawe";
            Console.WriteLine(text);

            String nameAndOwner = dog.ReturnNameAndOwner("Kacper");
            Console.WriteLine(nameAndOwner);

            Human me = new Human();
            me.FirstName = "Kacper";
            me.LastName = "Warda";
            me.Pet = dog;

            dog.Feed(1.0);
            dog.PrintWeight();

            me.Phone = new Phone("onePlus",
                "8Pro",
                2.3,
                "Android");
            Console.WriteLine(me.Phone.Model);


            Car theCar = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Value = 3500.0m,
                Year = 2010,
                Color = "black"

            };

            Console.WriteLine(theCar.ToString());

            Car car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Accord";

            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Accord";
            Console.WriteLine(car1.Equals(car2));


            me.Phone = new Phone("apple", "6s", 5.0, "iOs");
          
            me.Salary = 10000.0m;
            Console.WriteLine(me.Salary);
            me.Salary = 6000.0m;
            Console.WriteLine(me.Salary);
            me.Salary = 8000.0m;
            Console.WriteLine(me.Salary);
            me.Car = 35000.0m;
            Console.WriteLine(me.Car);
            double notZero = 1.0 - 0.9 - 0.1;
            decimal zero = 1.0m - 0.9m - 0.1m;
            Console.WriteLine(notZero);
            Console.WriteLine(zero);
            Console.WriteLine(me.Phone.Model);
        }
    }
}
