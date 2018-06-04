using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiasMesESemanaExtenso
{
    class Program
    {
        static string cultura = "pt-BR"; //Em Portugues            

        static void Main(string[] args)
        {
            //Dia da semana ========================

            Console.WriteLine("Dia da semana por extenso =========");
            Console.WriteLine();

            DiaSemana(cultura, 0);
            DiaSemanaAtual(cultura);

            Console.WriteLine();

            //Mes por Extenso ======================

            Console.WriteLine("Mês por extenso =========");
            Console.WriteLine();

            Mes(cultura, 1);
            MesAtual(cultura);

            Console.ReadKey();
        }

        /// <summary>
        /// Dia Semana por extenso
        /// </summary>
        /// <param name="cultura">Cultura desejada, por exemplo pt-BR</param>
        /// <param name="dia">Numero do dia da semana desejada</param>
        private static void DiaSemana(string cultura, int dia)
        {
            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetDayName((DayOfWeek)dia));

            //Abreviado (seg)            
            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetAbbreviatedDayName(DayOfWeek.Monday));            
        }

        /// <summary>
        /// Dia Semana atual por extenso
        /// </summary>
        /// <param name="cultura">Cultura desejada, por exemplo pt-BR</param>
        private static void DiaSemanaAtual(string cultura)
        {
            //Usando toString()
            Console.WriteLine(DateTime.Now.ToString("dddd", new CultureInfo(cultura)));

            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));

            //Dia atual com primeira letra maiúscula.
            string diaAtual = new CultureInfo(cultura).DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            Console.WriteLine(char.ToUpper(diaAtual[0]) + diaAtual.Substring(1));
        }

        /// <summary>
        /// Mes por extenso
        /// </summary>
        /// <param name="cultura">Cultura desejada, por exemplo pt-BR</param>
        /// <param name="mes">Numero do mes desejado</param>
        private static void Mes(string cultura, int mes)
        {
            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetMonthName(mes));

            //Abreviado
            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetAbbreviatedMonthName(mes));

            //Com primeira letra maiúscula.
            string month = new CultureInfo(cultura).DateTimeFormat.GetMonthName(mes);
            Console.WriteLine(char.ToUpper(month[0]) + month.Substring(1));
        }

        /// <summary>
        /// Mes atual por extenso
        /// </summary>
        /// <param name="cultura">Cultura desejada, por exemplo pt-BR</param>
        private static void MesAtual(string cultura)
        {
            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetMonthName(DateTime.Now.Month));

            //Abreviado
            Console.WriteLine(new CultureInfo(cultura).DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month));

            //Com primeira letra maiúscula.
            string month = new CultureInfo(cultura).DateTimeFormat.GetMonthName(DateTime.Now.Month);
            Console.WriteLine(char.ToUpper(month[0]) + month.Substring(1));
        }
    }
}
