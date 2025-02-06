using OOP_UsingCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Object Oriented Programming");

        CalculateRectangleArea rect = new CalculateRectangleArea();


        Console.Write("Enter Length of Rectangle: ");
        double lengthInput = Convert.ToDouble(Console.ReadLine());
        rect.SetLength(lengthInput);

        Console.Write("Enter Breadth of Rectangle: ");
        double breadthInput = Convert.ToDouble(Console.ReadLine());
        rect.SetBreadth(breadthInput);

        
        rect.CalculateArea();

    }
}
