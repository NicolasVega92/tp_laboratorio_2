using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador pasado que sea -, / o * sino retornara + en default
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {
            string operadorARetornar = "+";
            switch (operador)
            {
                case '-':
                    operadorARetornar = operador.ToString();
                    break;
                case '*':
                    operadorARetornar = operador.ToString();
                    break;
                case '/':
                    operadorARetornar = operador.ToString();
                    break;
                default:
                    break;
            }
            return operadorARetornar;
        }
        /// <summary>
        /// Valida y realiza la operacion pedida con el operador entre ambos numeros pasados
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado= 0;
            char auxOperador;
            if(operador.Length > 0)
            {
                auxOperador = operador[0];
            }
            else
            {
                auxOperador = ' ';
            }
            switch(ValidarOperador(auxOperador))
            {
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }



        

    }
}
