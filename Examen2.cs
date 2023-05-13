using System.Runtime.CompilerServices;

bool salir = false;

while (!salir)
{
    Console.WriteLine("========== MENU ==========");
    Console.WriteLine("1. Calcular indice de masa muscular");
    Console.WriteLine("2. Imprimir los numeros pares del 1 al 20.");
    Console.WriteLine("3. Calcular promedio notas");
    Console.WriteLine("4. Sumar 5 y 4.");
    Console.WriteLine("5. Salir");
    Console.WriteLine("==========================");

    Console.Write("Ingrese una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ha elegido la opción 1.");
            NewMethod();
            break;

        case "2":
            Console.WriteLine("Ha elegido la opción 2.");
            Par();
            break;

        case "3":
            Console.WriteLine("Ha elegido la opción 3.");
            NotaAlumnos();
            break;

        case "4":
            Sumar(5, 4);
            break;

        case "5":
            Console.WriteLine("Saliendo del programa...");
            salir = true;
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }
}
static void NewMethod()
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

static void Par()
{

    for (int i = 1; i <= 20; i++)
    {

        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void NotaAlumnos()
{
    Console.WriteLine("Ingrese el numero de alumnos: ");
    int n = int.Parse(Console.ReadLine());

    double[] Notas = RegistrarNotasAlumno(n);
    double totalNotas = CalcularTotalNotasAlumno(Notas);
    double promedioHoras = CalcularPromedioNotasAlumno(totalNotas, n);

    Console.WriteLine($"Total de las notas de los alumnos: {totalNotas}");
    Console.WriteLine($"El promedio de notas por alumno es: {promedioNotas}");
}
static double[] RegistrarNotasAlumno(int n)
{

    double[] Notas = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Ingrese las Notas del Alumno {i + 1}");
        Notas[i] = int.Parse(Console.ReadLine());
    }
    return Notas;
}
static double CalcularTotalNotasAlumno(double[] Notas)
{
    double totalNotas = 0;
    for (int i = 0; i < Notas.Length; i++)
    {
        totalNotas += Notas[i];
    }
    return totalNotas;
}
static double CalcularPromedioNotasAlumno(double totalNotas, int n)
{
    double promedioNotas = (double)totalNotas / n;
    return promedioNotas;
}

static int Sumar(int Num1, int Num2)
{
    Console.WriteLine("");
    Console.WriteLine("Introduce un numero: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduce otro numero: ");
    int num2 = int.Parse(Console.ReadLine());
    return num1 + num2;
    

}


