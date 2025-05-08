using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen01_ti_Alvarez_MartinezA
{
    public class JAAMCalculadora
    {
        private JAAMICalculos _JAAMfigura;

        public JAAMCalculadora(JAAMICalculos _JAAMfigura)
        {
            this._JAAMfigura = _JAAMfigura;
        }

        public void JAAMMostrarResultados()
        {
            Console.WriteLine($"Área: {_JAAMfigura.JAAMCalcularArea():F2}");
            try
            {
                Console.WriteLine($"Volumen: {_JAAMfigura.JAAMCalcularVolumen():F2}");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Volumen no disponible para esta figura.");
            }
        }
    }


}
