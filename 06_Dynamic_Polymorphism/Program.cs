using _06_Dynamic_Polymorphism;

Shape shape1 = new Circle();
Shape shape2 = new Square();

shape1.Draw();  // At runtime, the output will be "Drawing a circle."
shape2.Draw();  // At runtime, the output will be "Drawing a square."