using _05_Static_Polymorphism;

Calculator calculator = new Calculator();

//Example of compile-time polymorphism with method overloading
int resultInt = calculator.Add(5, 10);
Console.WriteLine("Integer Total: " + resultInt);

double resultDouble = calculator.Add(2.5, 3.4);
Console.WriteLine("Double Total: " + resultDouble);