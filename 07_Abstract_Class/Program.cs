using _07_Abstract_Class;

Addition additionCalculation = new Addition();
double additionResult = additionCalculation.PerformCalculation(5, 3);
additionCalculation.DisplayResult(additionResult);

Console.WriteLine();

Subtraction subtractionCalculation = new Subtraction();
double subtractionResult = subtractionCalculation.PerformCalculation(10, 4);
subtractionCalculation.DisplayResult(subtractionResult);
