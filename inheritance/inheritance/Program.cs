using task2;

Car car = new Car("BMW", 180, 5);
Console.WriteLine("Машина");
Console.WriteLine(car.Brand);
Console.WriteLine($"{car.MaxSpeed}км/ч");
Console.WriteLine($"{car.FuelConsumption}л/100км\n");
Console.WriteLine("Велосипед");
Bicycle bicycle = new Bicycle("FOXX", 60, "горный");
Console.WriteLine(bicycle.Brand);
Console.WriteLine($"{bicycle.MaxSpeed}км/ч");
Console.WriteLine(bicycle.Type);