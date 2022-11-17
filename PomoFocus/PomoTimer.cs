using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomoFocus
{
    public class PomoTimer
    {

        public int FocusTime { get; set; }
        public int RestTime { get; set; }
        public string FocusActivity { get; set; }
        public Timer Timer { get; set; }

        public DateTime DateTime { get; set; }


        public void Begin()
        {
            Console.Beep();
            Console.WriteLine("Welcome to your personal Pomo Focus Tracker!");
            Console.WriteLine("What will you be working on today?");
            FocusActivity = Console.ReadLine().Trim();

            Console.WriteLine("Your Focus Activity has been recorded as {0}.", FocusActivity);
            Thread.Sleep(300);
            Console.WriteLine("How much time will you want to focus on it and how much rest will you love to get?");
            Thread.Sleep(300);
            Console.WriteLine("Reply for Focus time in Minutes eg 25. Default value is 25mins");
            FocusTime = int.Parse( Console.ReadLine().Trim());
            
            Console.WriteLine("Reply for Rest time in Minutes eg 5. Default value is 5mins");
            RestTime = int.Parse(Console.ReadLine().Trim());
            Thread.Sleep(500);
            Console.WriteLine("Your Focus time has been set to {0} mins and Rest time to {1} mins. If you are ready, reply Y to begin! Clear all distractions before starting", FocusTime, RestTime);

            if (Console.ReadLine().ToUpper() == "Y")
            {

                Thread.Sleep(500);
                Console.Beep(200, 2000);
                Console.WriteLine("Your time has started now {0} and will end at {1} ", DateTime.Now.ToShortTimeString().ToString(), DateTime.Now.AddMinutes(FocusTime).ToShortTimeString().ToString());
                Thread.Sleep(FocusTime * 60*1000);
                Console.Beep(500, 2000);
                Console.WriteLine("Hurray, You have worked with Focus for {0} mins, Now you Deserve Rest!", FocusTime);
                Thread.Sleep(RestTime * 60 * 1000);
                Console.WriteLine("Hurray, You have worked with rested for {0} mins, Do you want to work again?!", RestTime);




            }
            else
            {
                Console.WriteLine("The input you entered is not valid!");
            }







        }


    }
}
