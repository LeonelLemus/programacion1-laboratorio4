using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculadora
{
    
    public string Marca { get; set; }
    public string Serie { get; set; }

    
    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }

   
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN;
        }
        return a / b;
    }
}


public class CalculadoraCientifica : Calculadora
{

    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
       
    }

   
    public double Potencia(double baseNum, double exponente)
    {
        return Math.Pow(baseNum, exponente);
    }

    public double Raiz(double numero)
    {
        return Math.Sqrt(numero);
    }

    public double Modulo(double dividendo, double divisor)
    {
        return dividendo % divisor;
    }

    public double Logaritmo(double numero, double baseLog)
    {
        return Math.Log(numero, baseLog);
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Calculadora calculadoraBasica = new Calculadora("Casio", "12345");

        Console.WriteLine("Calculadora básica:");
        Console.WriteLine("Suma: " + calculadoraBasica.Sumar(5, 3));
        Console.WriteLine("Resta: " + calculadoraBasica.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + calculadoraBasica.Multiplicar(5, 3));
        Console.WriteLine("División: " + calculadoraBasica.Dividir(5, 3));

        
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica("HP", "6789");

        
        Console.WriteLine("\nCalculadora científica:");
        Console.WriteLine("Potencia: " + calculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada: " + calculadoraCientifica.Raiz(16));
        Console.WriteLine("Módulo: " + calculadoraCientifica.Modulo(10, 3));
        Console.WriteLine("Logaritmo: " + calculadoraCientifica.Logaritmo(100, 10));

     
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
