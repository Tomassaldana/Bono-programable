using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class calculadora_de_permutaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora de Permutaciones y Coeficientes Multinomiales ===");
            Console.WriteLine("Oprima 1 para calcular n!");
            Console.WriteLine("Oprima 2 para calcular P(n, r)");
            Console.WriteLine("Oprima 3 para comparar P(10,3) y P(20,5)");
            Console.WriteLine("Oprima 4 para calcular coeficiente multinomial por palabra");
            Console.WriteLine("Oprima 5 para calcular coeficiente multinomial por cantidades");
            Console.WriteLine("Oprima 6 para ver ejemplos: BANANA y (4A, 3B, 2C)");

            string entradaTexto = Console.ReadLine();
            int desicion = int.Parse(entradaTexto);

            if (desicion == 1)
            {
                Console.WriteLine("\nHa escogido calcular el factorial de un numero.");
                Console.WriteLine("Ingrese n (entero no negativo):");
                entradaTexto = Console.ReadLine();
                int n = int.Parse(entradaTexto);

                if (!ValidarEntero(n))
                {
                    Console.WriteLine("Error: n debe ser un entero no negativo.");
                }
                else
                {
                    long resultado = Factorial(n);
                    Console.WriteLine($"\nProcedimiento: {n}! = {MostrarProcedimientoFactorial(n)}");
                    Console.WriteLine($"Resultado: {n}! = {resultado}");
                }
            }
            else if (desicion == 2)
            {
                Console.WriteLine("\nHa escogido calcular P(n, r).");
                Console.WriteLine("Ingrese n (entero no negativo):");
                entradaTexto = Console.ReadLine();
                int n = int.Parse(entradaTexto);

                Console.WriteLine("Ingrese r (entero no negativo, r <= n):");
                entradaTexto = Console.ReadLine();
                int r = int.Parse(entradaTexto);

                if (!ValidarEntero(n) || !ValidarEntero(r))
                {
                    Console.WriteLine("Error: n y r deben ser enteros no negativos.");
                }
                else if (r > n)
                {
                    Console.WriteLine("Error: r debe ser menor o igual a n.");
                }
                else
                {
                    long resultado = Permutacion(n, r);
                    Console.WriteLine($"\nProcedimiento:");
                    Console.WriteLine($"  P(n, r) = n! / (n - r)!");
                    Console.WriteLine($"  P({n}, {r}) = {n}! / ({n} - {r})!");
                    Console.WriteLine($"  P({n}, {r}) = {Factorial(n)} / {Factorial(n - r)}");
                    Console.WriteLine($"Resultado: P({n}, {r}) = {resultado}");
                }
            }
            else if (desicion == 3)
            {
                Console.WriteLine("\nComparando P(10, 3) y P(20, 5):\n");
                MostrarPermutacionDetallada(10, 3);
                Console.WriteLine();
                MostrarPermutacionDetallada(20, 5);
            }
            else if (desicion == 4)
            {
                Console.WriteLine("\nHa escogido calcular el coeficiente multinomial de una palabra.");
                Console.WriteLine("Ingrese la palabra (solo letras, sin espacios):");
                entradaTexto = Console.ReadLine().ToUpper();

                if (string.IsNullOrEmpty(entradaTexto) || !entradaTexto.All(char.IsLetter))
                {
                    Console.WriteLine("Error: ingrese una palabra valida con solo letras.");
                }
                else
                {
                    MostrarMultinomialPorPalabra(entradaTexto);
                }
            }
            else if (desicion == 5)
            {
                Console.WriteLine("\nHa escogido calcular el coeficiente multinomial por cantidades.");
                Console.WriteLine("Ingrese las cantidades separadas por comas (ej: 4,3,2):");
                entradaTexto = Console.ReadLine();

                string[] partes = entradaTexto.Split(',');
                List<int> cantidades = new List<int>();
                bool valido = true;

                foreach (string parte in partes)
                {
                    if (int.TryParse(parte.Trim(), out int cant) && ValidarEntero(cant))
                    {
                        cantidades.Add(cant);
                    }
                    else
                    {
                        valido = false;
                        break;
                    }
                }

                if (!valido || cantidades.Count == 0)
                {
                    Console.WriteLine("Error: ingrese solo enteros no negativos separados por comas.");
                }
                else
                {
                    MostrarMultinomialPorCantidades(cantidades);
                }
            }
            else if (desicion == 6)
            {
                Console.WriteLine("\n--- Ejemplo 1: Palabra BANANA ---");
                MostrarMultinomialPorPalabra("BANANA");

                Console.WriteLine("\n--- Ejemplo 2: 4 letras A, 3 letras B, 2 letras C ---");
                MostrarMultinomialPorCantidades(new List<int> { 4, 3, 2 });
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }

        static long Factorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * Factorial(numero - 1);
        }

        static long Permutacion(int n, int r)
        {
            return Factorial(n) / Factorial(n - r);
        }

        static long CoeficienteMultinomial(List<int> cantidades)
        {
            int n = 0;
            foreach (int c in cantidades) n += c;

            long denominador = 1;
            foreach (int c in cantidades) denominador *= Factorial(c);

            return Factorial(n) / denominador;
        }

        static bool ValidarEntero(int numero)
        {
            return numero >= 0;
        }

        static string MostrarProcedimientoFactorial(int n)
        {
            if (n == 0 || n == 1) return "1";
            string procedimiento = "";
            for (int i = n; i >= 1; i--)
            {
                procedimiento += i;
                if (i > 1) procedimiento += " x ";
            }
            procedimiento += " = " + Factorial(n);
            return procedimiento;
        }

        static void MostrarPermutacionDetallada(int n, int r)
        {
            long resultado = Permutacion(n, r);
            Console.WriteLine($"P({n}, {r}):");
            Console.WriteLine($"  Formula : P(n, r) = n! / (n - r)!");
            Console.WriteLine($"  P({n}, {r}) = {n}! / ({n - r})!");
            Console.WriteLine($"  P({n}, {r}) = {Factorial(n)} / {Factorial(n - r)}");
            Console.WriteLine($"  Resultado: {resultado}");
        }

        static void MostrarMultinomialPorPalabra(string palabra)
        {
            Dictionary<char, int> frecuencias = new Dictionary<char, int>();
            foreach (char c in palabra)
            {
                if (frecuencias.ContainsKey(c))
                    frecuencias[c]++;
                else
                    frecuencias[c] = 1;
            }

            int n = palabra.Length;
            List<int> cantidades = new List<int>(frecuencias.Values);

            Console.WriteLine($"\nPalabra: {palabra}");
            Console.WriteLine($"Letras y frecuencias:");
            foreach (var par in frecuencias)
                Console.WriteLine($"  '{par.Key}' aparece {par.Value} vez/veces");

            MostrarProcedimientoMultinomial(n, cantidades, frecuencias.Keys.ToList());
        }

        static void MostrarMultinomialPorCantidades(List<int> cantidades)
        {
            int n = 0;
            foreach (int c in cantidades) n += c;

            Console.WriteLine($"\nCantidades ingresadas: [{string.Join(", ", cantidades)}]");
            Console.WriteLine($"n = {string.Join(" + ", cantidades)} = {n}");

            MostrarProcedimientoMultinomial(n, cantidades, null);
        }

        static void MostrarProcedimientoMultinomial(int n, List<int> cantidades, List<char> letras)
        {
            long numerador = Factorial(n);
            long denominador = 1;
            string denominadorTexto = "";

            for (int i = 0; i < cantidades.Count; i++)
            {
                denominador *= Factorial(cantidades[i]);
                denominadorTexto += $"{cantidades[i]}!";
                if (i < cantidades.Count - 1) denominadorTexto += " x ";
            }

            long resultado = numerador / denominador;

            Console.WriteLine($"\nProcedimiento:");
            Console.WriteLine($"  Formula: n! / (n1! x n2! x ... x nk!)");
            Console.WriteLine($"  = {n}! / ({denominadorTexto})");
            Console.WriteLine($"  = {numerador} / {denominador}");
            Console.WriteLine($"\nResultado: {resultado} palabras distintas pueden formarse.");
        }
    }
}
