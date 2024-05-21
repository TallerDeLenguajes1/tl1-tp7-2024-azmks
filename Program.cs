using System.Xml.Serialization;
using calculadoraNamespace;
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Calculadora");
Console.WriteLine("\n  Operaciones:");
Console.WriteLine("    + (Suma)\n    - (Resta)\n    * (Multiplicacion)\n    / (Division)");
Console.WriteLine("    L (Limpiar)\n    N (Salir de Calculadora)");

string op;
double num;

Calculadora C = new Calculadora();

do
{
    Console.WriteLine("Ingrese una operacion (+, - , *, /): ");
    op = Console.ReadLine();
    if (op == "N")
        break;
    Console.WriteLine("Ingrese un numero: ");
    num = double.Parse(Console.ReadLine());
    switch (op)
    {
        case "+":
            C.Sumar(num);
            break;
        case "-":
            C.Restar(num);
            break;
        case "*":
            C.Multiplicar(num);
            break;
        case "/":
            if (num != 0)
                C.Dividir(num);
            else
                Console.WriteLine("No se puede dividir por 0!");
            break;
        case "L":
            C.Limpiar();
            break;
        case "N":
            break;
        default:
            Console.WriteLine("Operador Invalido!");
            break;
    }
} while (op != "N");

Console.WriteLine("\nRESULTADO: "+C.Resultado);