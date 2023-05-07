using System.Drawing;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hedgehogs = { 8, 1, 9 };
            int color = 2; 
            int meeting = MeetingsChange(color, hedgehogs);
            Console.WriteLine(meeting);
        }

        public static int MeetingsChange(int color, int[] hedgehogs)
        {

            int meetingCount = 0;
            while (true)
            {
                if (hedgehogs[(color + 1) % 3] > 0 && hedgehogs[(color + 2) % 3] > 0)
                {
                    hedgehogs[(color + 1) % 3]--;
                    hedgehogs[(color + 2) % 3]--;
                    //hedgehogs[color]++;
                    meetingCount++;
                }
                else if (hedgehogs[color] == hedgehogs.Sum())
                {
                   
                    break;
                }
                else
                {
                    return -1;
                }
            }
            return meetingCount;
        }
    }
}


//Пояснення алгоритму:

//Спочатку перевіряється можливість змінити колір за допомогою перевірки, чи всі їжачки вже в заданому колірі. Якщо так, то повертається 0.
//В циклі while перевіряється можливість змінити колір за допомогою перевірки, чи є хоча б один їжачок кольору, відмінного від заданого, та чи є ще хоча б по одному їжачку двох інших кольорів. Якщо так, то проводиться зустріч, під час якої змінюється колір зустрічаючих їжачків. Якщо не вдається змінити колір, то повертається -1. Якщо успішно змінено всіх їжачків у заданий колір, то цикл завершується і повертається кількість зустрічей.
//Приклад використання: