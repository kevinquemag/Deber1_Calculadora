using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hola, empezamos?");
            var respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
          
                double numero1;
                double numero2;
                string operacion;
                double resultado;

                Console.WriteLine("Ingresa en palabras la operacion a realizar ");
                Console.WriteLine("Suma");
                Console.WriteLine("Resta");
                Console.WriteLine("Multiplicacion");
                Console.WriteLine("Division");
                Console.WriteLine("Raiz");
                Console.WriteLine("Potencia");
                Console.WriteLine("Inversa");

                operacion = Console.ReadLine();
                

        if (operacion == "Suma")
               
                {

                    Console.WriteLine("Digite el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 + numero2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    Console.ReadLine();
                }

        if (operacion == "Resta")
                
                {

                    Console.WriteLine("Digite el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    Console.ReadLine();
                }

            if (operacion == "Multiplicacion")
                
                {

                    Console.WriteLine("Digite el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 * numero2;
                    Console.WriteLine("El resultado de la Multiplicacion es: " + resultado);
                    Console.ReadLine();
                }

    if (operacion == "Division")
                {

                    Console.WriteLine("Digite el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = numero1 / numero2;
                    Console.WriteLine("El resultado de la Division es: " + resultado);
                    Console.ReadLine();
                }

                if (operacion == "Raiz")
                {

                    Console.WriteLine("Digite el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Sqrt(numero1);
                    Console.WriteLine("El resultado de la Raiz es: " + resultado);
                    Console.ReadLine();

                }

                if (operacion == "Potencia")
                {

                    Console.WriteLine("Digite el primer numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite el segundo numero");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Pow(numero1,numero2);
                    Console.WriteLine("El resultado de la Potencia es: " + resultado);
                    Console.ReadLine();

                }

                if (operacion == "Inversa")
                {

                    Console.WriteLine("Digite un numero");
                    numero1 = Convert.ToDouble(Console.ReadLine());

                    resultado = 1/(numero1);
                    Console.WriteLine("El resultado de la Inversa es: " + resultado);
                    Console.ReadLine();

                }


                Console.WriteLine("Quieres seguir calculando?");
                respuesta = Console.ReadLine();

                Console.Clear();

            }
        }
    }
}
