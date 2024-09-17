// track
Console.WriteLine("список команд");
Console.WriteLine("Команда 1 : \"+\"");
Console.WriteLine("Команда 2 : \"-\"");
Console.WriteLine("Команда 3 : \"test\"");
Console.WriteLine("Команда выход : \"exit\"");



while (true)
{
    Console.WriteLine("Введите команды:");


    switch (Console.ReadLine())
    {
        case "+": Console.WriteLine("начинаю команду 1 ..."); break;
        case "-": Console.WriteLine("начинаю команду 2 ..."); break;
        case "test": Console.WriteLine("начинаю команду тест"); break;
        case "exit": return;  //Выход

        default:
            Console.WriteLine("неизветная команда");
            break;
    }

}

