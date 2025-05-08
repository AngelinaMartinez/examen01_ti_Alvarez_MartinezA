using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace examen01_ti_Alvarez_MartinezA
{
    public class JAAMCirculo : JAAMICalculos
    {
        private double radio;

        public JAAMCirculo(double radio)
        {
            this.radio = radio;
        }         

        public double JAAMCalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        
        public double JAAMCalcularVolumen()
        {
            throw new NotImplementedException("El círculo no tiene volumen.");
        }
    }
}
