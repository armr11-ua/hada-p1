using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            string opcion2;
            double time;
            double conversion;

            do
            {
                Console.WriteLine("Indica la unidad segundos/minutos/horas(s/m/h): ");
                opcion = Console.ReadLine();
                opcion = opcion.ToLower();
                Console.WriteLine("Indica el tiempo: ");
                time = double.Parse(Console.ReadLine());
                if (opcion == "s")
                {
                    conversion = HadaP1.Seconds2Minutes(time);
                }
                else if (opcion == "m")
                {
                    conversion = HadaP1.Minutes2Seconds(time);

                }
                else if (opcion == "h")
                {
                    conversion = HadaP1.Hours2Minutes(time);

                }

                Console.WriteLine("¿Quiere hacer mas conversiones?(s/n): ");
                opcion2 = Console.ReadLine();

            } while (opcion2 != "n");

        }
    }
}
