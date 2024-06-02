using System.Collections;

namespace Funcoes
{
    public static class Functions
    {
        public static void Menu()
        {
            string timeUser = "0";
            Console.Clear();
            Console.WriteLine("Defina o tempo que deseja cronometrar:");
            Console.WriteLine("Formatos: 1s (segundos), 1m(minutos), 1h(horas)");
            timeUser = Console.ReadLine().ToLower();
            char type = char.Parse(timeUser.Substring(timeUser.Length - 1, 1));
            int convTime = 0;

            switch (type)
            {
                case 'm': convTime = 60; break;
                case 'h': convTime = 3600; break;
                default: convTime = 1; break;
            }

            int timeToCount = int.Parse(timeUser.Substring(0, timeUser.Length - 1)) * convTime;
            Console.WriteLine(timeToCount);
            Console.WriteLine(convTime);
            Console.ReadKey();
            if (timeUser.Length < 2) Environment.Exit(0);
            else start(timeToCount);
        }

        public static void start(int time)
        {
            Console.Clear();
            int counter = 0;
            while (counter != time)
            {
                counter++;
                Console.WriteLine(counter);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Tempo Finalizado\nRetornando ao Menu");
            Thread.Sleep(2000);

            Menu();
        }
    }


}
