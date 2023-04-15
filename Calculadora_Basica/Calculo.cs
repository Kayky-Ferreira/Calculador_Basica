using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Basica
{
    internal class Calculo
    {            
        //condição da operação e calculo
        public float calculo_operacao(float valor1, float valor2, float tipo_operacao)
        {
            float resultado = 0;

            switch (tipo_operacao)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
                case 5:
                    resultado = (valor1 / 100) * valor2;
                    break;
            }
         return resultado;
        }
   
    }
}
