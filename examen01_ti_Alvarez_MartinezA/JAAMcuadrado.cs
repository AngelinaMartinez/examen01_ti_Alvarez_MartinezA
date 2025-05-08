using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen01_ti_Alvarez_MartinezA
{
    public class JAAMcuadrado : JAAMICalculos
    {
        private double lado;

        public JAAMcuadrado(double lado)
        {
            this.lado = lado;
        }

        public double JAAMCalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        public double JAAMCalcularVolumen()
        {
            throw new NotImplementedException("El cuadrado no tiene volumen.");
        }
    }

}
}
