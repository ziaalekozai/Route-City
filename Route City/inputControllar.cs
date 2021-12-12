using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_City
    {
    /// <summary>
    /// Receive the inputs.
    /// Made by Zia.
    /// </summary>
    class InputControllar
        {
        /// <summary>
        /// Bus logo.
        /// Made by Zia.
        /// </summary>
        private static void bussLogo()
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t  ____________________________________________________________ ");
            Console.WriteLine("\t\t |     |      |     |     |     |     |     |     |     |     |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t |  () |      |  () |  () |     |  () |  () |     |  () |  () |");
            Console.WriteLine("\t\t |_<  >|______|__||_|__||_|_____|__||_|__||_|_____|__||_|__||_|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t |____________________________________________________________|");

            Console.WriteLine("\t\t |       . ' .              Buss            . ' .             |");
            Console.WriteLine("\t\t (______'  o  '____________________________'  o  '____________)");
            Console.WriteLine("\t\t         ' . '                              ' . '              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("<<<=============================================================================================<<<");
            }
        /// <summary>
        /// To find the distance between stops.
        /// Made by Mohammad and Zia.
        /// </summary>
        static int[,] graph =
               {
                    {0,4,7,0,7,0,0,0,0,0 },
                    {4,0,3,12,0,0,0,5,0,0},
                    {7,3,0,0,0,0,4,0,12,0},
                    {0,12,0,0,0,0,0,7,3,0},
                    {7,0,0,0,0,3,5,0,0,0 },
                    {0,0, 0,0,3,0,5,0,0,0},
                    {0,0,4,0,5,5,0,8,13,8},
                    {0,5,0,7,0,0,8,0,0,9},
                    {0,0,12,3,0,0,13,0,0,7},
                    {0,0,0,0,0,0,8,9,7,0}
            };
        /// <summary>
        /// Menu to choos the stations.
        /// Made by Zia.
        /// </summary>
        public static void chooseStations()
            {
            bussLogo();
            Console.WriteLine("Mata in ett nummer mellan [0]-[9] som motsvarar hållplatsen du vill åka till:" +
                "\n\n[0] A\t [1] B\t [2] C\t [3] D\t [4] E\t [5] F\t [6] G\t [7] H\t [8] I\t [9] J\n");

            Console.Write("Från hållplats : ");
            int start = intControllar(9,0);
            Console.Write("Till hållplats : ");
            int end = intControllar(9,0);
            Console.WriteLine();
            Route_City.RuteCity.Dijkstra(graph,start,end);
            //Calculates the path from start to end.
            Console.WriteLine();
            startAgain();
            }
        /// <summary>
        /// Menu to start again and to close the program.
        /// Made by Zia.
        /// </summary>
        public static void startAgain()
            {
            Console.WriteLine("[O]För starta om \n[S]För stänga ner");
            var userInput = Console.ReadLine().ToLower();

            if (userInput != "o" && userInput != "s")
            // Check if input is not (s) and (o). 
                {
                Console.Clear();
                bussLogo();
                Console.WriteLine("Fel input försök igen");
                startAgain();
                }
            else if (userInput == "o")
                {
                Console.Clear();
                chooseStations();
                }
            else if (userInput == "s")
                {
                Console.WriteLine("Välkommen Åter");
                System.Environment.Exit(0);
                }
            }
        /// <summary>
        /// controls the int inputs.
        /// Made by Zia.
        /// </summary>
        /// <param name="maxValue">the maxvalue</param>
        /// <param name="minValue">the minvalue</param>
        /// <returns></returns>
        public static int intControllar(int maxValue,int minValue)
            {
            int check;
            while (!Int32.TryParse(Console.ReadLine(),out check) || check > maxValue || check < minValue)
            //Check if the input does not have the same maxValue and minValue or if it is not a int then send a message.
                {
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }
        }
    }

