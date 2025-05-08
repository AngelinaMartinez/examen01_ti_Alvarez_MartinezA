using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace examen01_ti_Alvarez_MartinezA
{
    public class Program
    {
        static void Main(string[] args)
        {
            

           
            //JAAMICalculos cuadrado = new JAAMCuadrado(4);
            //JAAMICalculos sherpe = new JAAMSherpe(3);
            //JAAMICalculos cube= new JAAMCubo(2);
            
            //Calculadora calculadoraCuadrado = new Calculadora(cuadrado);
            //Calculadora calculadoraEsfera = new Calculadora(esfera);
            //Calculadora calculadoraCubo = new Calculadora(cubo);


            JAAMICalculos circulo = new JAAMCirculo(5);
            JAAMICalculos Cuadrado = new JAAMCuadrado(4);
           // JAAMICalculos Esfera = new JAAM(4);
            JAAMICalculos Cubo = new JAAMCubo(2);
            JAAMCalculadora calculadoraCirculo = new JAAMCalculadora(circulo);
            JAAMCalculadora calculadoraCuadrado = new JAAMCalculadora(Cuadrado);
            JAAMCalculadora calculadoraEsfera = new JAAMCalculadora(JAAMEsfera);
            JAAMCalculadora calculadoraCubo = new JAAMCalculadora(Cubo);
          
         

        }
    }
    }
