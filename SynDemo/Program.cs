namespace SynDemo;

class Program
{
    static void Main(string[] args)
    {
        float result;

        Console.WriteLine("""
                          Welcome to the calculator, dude...
                          Please, give me first integer :
                          """);
        float firstInteger = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please, give me second integer :");
        float secondInteger = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("""
                          Please, give me option :
                          1) Summ / 2) Subst
                          3) Div / 4) Multi
                          """);
        int choice = Convert.ToInt32(Console.ReadLine());

        if (secondInteger == 0 && choice == 3)
        {
            Console.WriteLine("Error! Divide by zero? F*cking moron");
        }
        else
        {
            switch (choice)
            {
                case 1:
                    result = firstInteger + secondInteger;
                    Console.WriteLine($"The summary result equals {result}");
                    break;
                case 2:
                    result = firstInteger - secondInteger;
                    Console.WriteLine($"the substraction result equals {result}");
                    break;
                case 3:
                    result = firstInteger / secondInteger;
                    Console.WriteLine($"The division result equals {result}");
                    break;
                case 4:
                    result = firstInteger * secondInteger;
                    Console.WriteLine($"The multiplication result equals {result}");
                    break;
            }
        }
    }
}