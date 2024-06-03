using System.Collections;

namespace Funcoes
{
    public static class Functions
    {
        public static void Menu()
        {
            int horas = 0;
            int minutos = 0;
            int segundos = 0;
            Console.Clear();
            Console.WriteLine("Defina o tempo que deseja cronometrar:");
            Console.WriteLine("Horas:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Minutos:");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundos:");
            segundos = int.Parse(Console.ReadLine());

            int totalSegundos = (horas * 3600) + (minutos * 60) + segundos;

            Console.Clear();
            for (int start_ = 3; start_ >= 0; start_--)
            {
                Console.WriteLine($"Iniciando em\n>>>{start_}<<<");
                Thread.Sleep(1000);
                Console.Clear();
            }

            start(totalSegundos);

        }

        public static void start(int totalSegundos)
        {

            int counter = 0;
            int hora = 0;
            int minutos = 0;
            int segundos = 0;

            while (counter != totalSegundos)
            {
                Console.Clear();
                counter++;
                segundos++;
                if (segundos == 60)
                {
                    minutos++;
                    segundos = 0;
                }
                if (minutos == 59 && segundos == 60)
                {
                    hora++;
                    minutos = 0;
                    segundos = 0;
                }
                Console.WriteLine($">>> {hora}:{minutos}:{segundos}");
                Thread.Sleep(1000);

            }
            Console.WriteLine("Tempo Finalizado\nRetornando ao Menu");
            Console.ReadKey();

            Menu();
        }
    }
}


