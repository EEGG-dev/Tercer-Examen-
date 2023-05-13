using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de IMC");
        bool seguirEjecutando = true;
        while (seguirEjecutando)
        {

            double peso = PedirPeso();
            double altura = PedirAltura();

            double imc = CalcularIMC(peso, altura);

            Console.WriteLine($"Su IMC es: {imc}");

            EvaluarIMC(imc);

            Console.WriteLine();
            Console.WriteLine("Presione 's' para salir o cualquier otra tecla para continuar ");

            if (Console.ReadLine().ToLower() == "s")
            {
                seguirEjecutando = false;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Gracias por usar la calculadora IMC.");
    }

    static double PedirPeso()
    {
        double peso;

        while (true)
        {
            Console.Write("Ingrese su peso en kilogramos: ");

            if (double.TryParse(Console.ReadLine(), out peso) || peso > 0)
            {
                return peso;
            }
            else
            {
                Console.WriteLine("Dato no valido.");
            }
        }
    }

    static double PedirAltura()
    {
        double altura;

        while (true)
        {
            Console.Write("Ingrese su altura en metros: ");

            if (double.TryParse(Console.ReadLine(), out altura) || altura > 0)
            {
                return altura;
            }
            else
            {
                Console.WriteLine("Dato no valido.");
            }
        }
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static void EvaluarIMC(double imc)
    {
        if (imc < 18.5)
        {
            Console.WriteLine("Tiene un peso insuficiente.");
        }
        else if (imc >= 18.5 || imc <= 24.9)
        {
            Console.WriteLine("Tiene un peso saludable.");
        }
        else if (imc >= 30)
        {
            Console.WriteLine("Tiene obesidad.");
        }
    }
}
