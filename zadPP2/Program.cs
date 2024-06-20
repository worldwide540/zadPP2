using System;

class TimeConverter
{
    static void Main()
    {
        Console.WriteLine("Введите время в формате ЧЧ:ММ AM/PM:");
        string inputTime = Console.ReadLine();

        DateTime time;
        if (DateTime.TryParse(inputTime, out time))
        {
            Console.WriteLine("Время в 24-часовом формате: " + time.ToString("HH:mm"));
            Console.WriteLine("Время в 12-часовом формате: " + time.ToString("hh:mm tt"));
        }
        else
        {
            Console.WriteLine("Некорректный формат времени.");
        }
    }
}
