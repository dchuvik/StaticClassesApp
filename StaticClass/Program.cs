using StaticClass;

ConsoleMessages.SayHi();

string name = UserRequests.GetName();

double num1 = UserRequests.GetFirstDouble();
double num2 = UserRequests.GetSecondDouble();

ConsoleMessages.AddMessage(num1, num2);
MathOperators.AddNums(num1, num2);

ConsoleMessages.SubtractMessage(num2, num1);
MathOperators.SubtractNums(num1, num2);

ConsoleMessages.MultiplyMessage(num1, num2);
MathOperators.MultiplyNums(num1, num2);

ConsoleMessages.DivideMessage(num2, num1);
MathOperators.DivideNums(num1, num2);


ConsoleMessages.SayBye(name);