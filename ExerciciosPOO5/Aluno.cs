using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO5
{
    internal class Aluno
    {
        public String? Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double PontosTotal()
        {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado()
        {
            if (PontosTotal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public String Situacao()
        {
            if (Aprovado())
            {
                return "Aprovado! :)";
            }
            else
            {
                return $"Reprovado! :( \nFaltaram {60 - PontosTotal()} pontos. :(";
            }
        }             
        public override string ToString()
        {
            return $"Nota Final = {PontosTotal().ToString("F2")}";
        }
    }
}
