using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj operator (+, -, *, /): ");
        char op = Console.ReadLine()[0];

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double wynik;

        switch (op)
        {
            case '+':
                wynik = a + b;
                break;
            case '-':
                wynik = a - b;
                break;
            case '*':
                wynik = a * b;
                break;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Błąd: dzielenie przez zero!");
                    return;
                }
                wynik = a / b;
                break;
            default:
                Console.WriteLine("Nieznany operator!");
                return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }
}
