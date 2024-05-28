
Menu();


static void Menu()
{
    string timeUser = "0";
    Console.Clear();
    Console.WriteLine("Defina o tempo que deseja cronometrar:");
    Console.WriteLine("Formatos: 1s (segundos), 1m(minutos), 1h(horas)");
    timeUser = Console.ReadLine().ToLower();
    char type = char.Parse(timeUser.Substring(timeUser.Length - 1, 1));
    int timeToCount = int.Parse(timeUser.Substring(0, timeUser.Length - 1));
    //Console.WriteLine(timeUser);
    //Console.WriteLine(type);
    if (timeUser.Length < 2) Environment.Exit(0);
    else start(timeToCount);
}

static void start(int time)
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