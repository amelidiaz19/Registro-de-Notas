using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Validacion
    {
        public bool Vacio(string valor)
        {
            if (valor == "" || valor == null || valor.Trim().Length == 0)
            {
                return true;
            }
            return false;
        }

        public bool SoloLetras(string valor)
        {
            foreach (var c in valor)
            {
                if (!Char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SoloNumeros(string valor)
        {
            foreach (char c in valor)
            {
                if (Char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Rango(string valor)
        {
            if (float.Parse(valor) >= 0 && float.Parse(valor) <= 20)
            {
                return false;
            }
            return true;

        }
    }
}
