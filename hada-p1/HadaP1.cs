using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    internal class HadaP1
    {   
        /// <summary>
        /// Conversor de segundos a minutos.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s)
        {
            if (s <= 0) return 0;
            return s / 60;
        }

        /// <summary>
        /// Conversor de minutos a segundos.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }
        /// <summary>
        /// Conversor de horas a minutos.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public static double Hours2Minutes(double h)
        {
            return h * 60;
        }
    }
}
