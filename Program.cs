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


