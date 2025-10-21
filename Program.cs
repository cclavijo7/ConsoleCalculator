namespace Calculadora_en_consola
{
    public class Calculadora
    {
       public static void Main(string[] args)
        {           
            Console.WriteLine("=== CALCULADORA ===");
            Console.Write("Ingresa el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSelecciona la operacion:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raiz cuadrada del primer numeo");
            Console.WriteLine("7. Modulo");

            Console.Write("Opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1: resultado = num1 + num2; break;
                case 2: resultado = num1 - num2; break;
                case 3: resultado = num1 * num2; break;
                case 4: resultado = num1 / num2; break;
                case 5: resultado = Math.Pow(num1, num2); break;
                case 6: resultado = Math.Sqrt(num1); break;
                case 7: resultado = num1 % num2; break;
                default: Console.WriteLine("Opcion invalida"); return;

            }

            Console.WriteLine("\nResultado: " + resultado);
            
        }
    }
}
