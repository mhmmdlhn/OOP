using _08_Interface;

// Using objects of classes that implement the interface

IShape circle = new Circle { Name = "Circle" };
circle.Draw();

IShape square = new Square { Name = "Square" };
square.Draw();