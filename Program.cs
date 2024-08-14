using System;

namespace TaskJunior7
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int waitingLine = 10;
            int minutesOfWaiting = 60;
            int expectationInHours;
            int expectationInMinutes;
            int peopleInTheQueue;

            Console.WriteLine("Приветствую тебя дорогой посититель нашей полеклиники!\nДля облегчения пользованием нашей полеклиники была созданна программа, которая обределяет кол-во времение ожидания в живой очедеди\n");
            Console.Write("Введите кол-во людей: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            peopleInTheQueue = peopleInLine * waitingLine;
            expectationInHours = peopleInTheQueue / minutesOfWaiting;
            expectationInMinutes = peopleInTheQueue % minutesOfWaiting;

            Console.Write($"\nКол-во времени ожидания вашей очереди составляет: {expectationInHours} часов и {expectationInMinutes} минут ");
        }
    }
}
