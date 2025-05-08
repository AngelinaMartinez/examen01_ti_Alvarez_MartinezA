using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen01_ti_Alvarez_MartinezA
{
    public class JAAMCubo : JAAMICalculos
    {
        private double lado;

        public JAAMCubo(double lado)
        {
            this.lado = lado;
        }

        public double JAAMCalcularArea()
        {
            return 6 * Math.Pow(lado, 2);
        }

        public double JAAMCalcularVolumen()
        {
            return Math.Pow(lado, 3);
        }
    }

}
}
 