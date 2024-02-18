using _02_Encapsulation;

// Creating an instance of the Car class
Car myCar = new Car();

// Setting values using properties
myCar.Make = "Toyota";
myCar.Model = "Camry";
myCar.Year = 2022;

// Accessing values using properties
Console.WriteLine($"Car Info: Make - {myCar.Make}, Model - {myCar.Model}, Year - {myCar.Year}");

// Using a method to display information
myCar.DisplayCarInfo();

Car car = new();
car.Make = "Dacia";
car.Model = "Duster";
car.Year = 1800;

car.DisplayCarInfo();