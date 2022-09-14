// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.


using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaTotal = 0;
            string[] valorHora= Console.ReadLine().Split(' ');
            int horaInicio=int.Parse(valorHora[0]);
            int horaFinal = int.Parse(valorHora[1]);

            if (horaInicio < horaFinal)
            {
                horaTotal = horaFinal - horaInicio;
                Console.WriteLine($"O jogo durou {horaTotal} horas");
            }
            else if (horaInicio ==0 && horaFinal==0)
            {
                Console.WriteLine("O jogo durou 24 horas");
            }
            else
            {
                horaTotal = (24 - horaInicio) + horaFinal;
                Console.WriteLine($"O jogo durou {horaTotal} horas");
            }
        }
    }
}
