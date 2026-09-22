using compo.Engine;
using compo.Car;
using compo.Computer;

Car mycar = new Car("Toyota", "V6", 300);
mycar.startCar();


//compostion
//computer 

Console.WriteLine("\nCreating a computer...");
Computer myComputer = new Computer("Dell", "Intel i7", 16);
myComputer.boot();
