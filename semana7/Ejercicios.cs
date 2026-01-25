using System;
using System.Collections.Generic;

namespace VerificacionBalanceada
{
    // Clase encargada de verificar el balance de la expresión
    public class BalanceChecker
    {
        public bool EsBalanceada(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)  // Recorre cada carácter en la expresión
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0) return false;

                    char apertura = pila.Pop();

                    if (!Coinciden(apertura, c))
                        return false;
                }
            }

            return pila.Count == 0;
        }

        private bool Coinciden(char apertura, char cierre) // Verifica si los paréntesis coinciden
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }
    }

}
