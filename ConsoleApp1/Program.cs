internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("hello, world");





        string respuesta = "si";

        while (respuesta.ToLower() != "no")
        {
            string[] autos = {
                "Ford Mustang",
                "Chevrolet Corvette",
                "Porsche Cayman"
            };

            double[] tiempos = new double[3];

            Console.WriteLine("=== Carrera de autos ===");

            for (int i = 0; i < autos.Length; i++)
            {
                bool tiempoValido = false;

                while (!tiempoValido)
                {
                    Console.Write("Tiempo del " + autos[i] + " en segundos: ");
                    string dato = Console.ReadLine();

                    if (double.TryParse(dato, out tiempos[i]) && tiempos[i] > 0)
                    {
                        tiempoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Escribe un número mayor que cero.");
                    }
                }
            }

            // Ordenar los autos del menor tiempo al mayor
            for (int i = 0; i < tiempos.Length - 1; i++)
            {
                for (int j = i + 1; j < tiempos.Length; j++)
                {
                    if (tiempos[j] < tiempos[i])
                    {
                        double tiempoTemporal = tiempos[i];
                        tiempos[i] = tiempos[j];
                        tiempos[j] = tiempoTemporal;

                        string autoTemporal = autos[i];
                        autos[i] = autos[j];
                        autos[j] = autoTemporal;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Orden de llegada:");

            for (int i = 0; i < autos.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + autos[i] + " - " +
                                  tiempos[i] + " segundos");
            }

            do
            {
                Console.WriteLine();
                Console.Write("¿Desea realizar otra carrera? Escriba Si o No: ");
                respuesta = Console.ReadLine().Trim().ToLower();

                if (respuesta != "si" && respuesta != "sí" && respuesta != "no")
                {
                    Console.WriteLine("Responda solamente Si o No.");
                }
            }
            while (respuesta != "si" && respuesta != "sí" && respuesta != "no");
        }

        Console.WriteLine("Programa finalizado.");
    }
}