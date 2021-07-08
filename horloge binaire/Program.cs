using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace horloge_binaire
{
    class Program
    {
        static void Main(string[] args)
        {
             String modelHorloge;
             List<String> pause = ReadFile(out modelHorloge);
            Heure(pause, modelHorloge);



        }

        static List<String> ReadFile(out String  modeleHorloge)
        {
            List<String> pause = new List<string>();
            modeleHorloge = "";
            try
            {
                //Créez une instance de StreamReader pour lire à partir d'un fichier
                using (StreamReader sr = new StreamReader($"C:\\Users\\{System.Environment.UserName}\\Desktop\\horloge.txt"))
                {
                    string line;
                    modeleHorloge = sr.ReadLine();
                    // Lire les lignes du fichier jusqu'à la fin.
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Console.WriteLine(line);
                        pause.Add(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Le fichier n'a pas pu être lu.");
                Console.WriteLine(e.Message);
            }
            return pause;
        }





        static void MarioMusic(Object ct)
        {
            CancellationToken token = (CancellationToken)ct;
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }
        static void TetrisMusic(Object ct)
        {
            CancellationToken token = (CancellationToken)ct;
            Console.Beep(1320, 500);
            Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125);
            Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250);
            Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250);
            Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250);
            Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500);


        }


        static void Affiche(Boolean[] flag, int ligne)
        {

            String[] s = new string[] { "┌───────┐", "│       │", "│       │", "│       │", "└───────┘" };

            for (int i = 0; i < s.Length; i++)
            {
                Console.SetCursorPosition(30, 10 + (ligne * 5) + i);
                for (int j = 0; j < flag.Length; j++)
                {
                    if (flag[j]) { Console.BackgroundColor = ConsoleColor.DarkGreen; } else Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(s[i]);
                }


            }
        }

        static void Binaire(int heure, int minute, int seconde)
        {

            Boolean[] falgH = new Boolean[6];
            Boolean[] falgM = new Boolean[6];
            Boolean[] falgS = new Boolean[6];
            int modulo = 32;
            int cpt = 0;

            while (modulo != 0)
            {

                if (heure % modulo != heure)
                {
                    falgH[cpt] = true;
                    heure = heure - modulo;
                }
                else
                {
                    falgH[cpt] = false;
                }
                if (minute % modulo != minute)
                {
                    falgM[cpt] = true;
                    minute = minute - modulo;
                }
                else
                {
                    falgM[cpt] = false;
                }
                if (seconde % modulo != seconde)
                {
                    falgS[cpt] = true;
                    seconde = seconde - modulo;
                }
                else
                {
                    falgS[cpt] = false;
                }

                modulo = modulo / 2;
                cpt++;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Affiche(falgH, 0);
            Affiche(falgM, 1);
            Affiche(falgS, 2);
        }

        static void Braille(int heure, int minute, int seconde)
        {
            // █
            String[,] number = new string[10, 9]
             {
                { "┌┐ ▄▄", "││ ██", "└┘ ▀▀", "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘" },
                { "▄▄ ┌┐", "██ ││", "▀▀ └┘", "┌┐ ┌┐", "││ ││", "└┘ └┘", "┌┐ ┌┐", "││ ││", "└┘ └┘" } ,
                { "▄▄ ┌┐", "██ ││", "▀▀ └┘", "▄▄ ┌┐", "██ ││ ", "▀▀ └┘", "┌┐ ┌┐", "││ ││", "└┘ └┘"   },
                { "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘", "┌┐ ┌┐", "││ ││", "└┘ └┘" },
                { "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "┌┐ ▄▄", "││ ██", "└┘ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘"  } ,
                { "▄▄ ┌┐", "██ ││", "▀▀ └┘", "┌┐ ▄▄", "││ ██", "└┘ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘" } ,
                { "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "▄▄ ┌┐", "██ ││", "▀▀ └┘", "┌┐ ┌┐", "││ ││", "└┘ └┘" },
                { "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘" } ,
                { "▄▄ ┌┐", "██ ││", "▀▀ └┘", "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘" } ,
                { "┌┐ ▄▄", "││ ██", "└┘ ▀▀", "▄▄ ┌┐", "██ ││", "▀▀ └┘", "┌┐ ┌┐", "││ ││", "└┘ └┘" } 

             };
            string[] seperateur = new string[] { "┌┐ ┌┐", "││ ││", "└┘ └┘" , "▄▄ ▄▄", "██ ██", "▀▀ ▀▀", "┌┐ ┌┐", "││ ││", "└┘ └┘" };
            AfficheBraille(number, heure, 25, 10);
             AfficheSeparateur(seperateur, 40, 10);
             AfficheBraille(number, minute, 48, 10);
             AfficheSeparateur(seperateur, 63, 10);
             AfficheBraille(number, seconde, 71, 10);


        }

        static void Digital(int heure, int minute, int seconde)
        {
            String[,] number = new string[10, 6]
            {
                 { "   ___   ", "  / _ \\  ", " | | | | ", " | | | | ", " | | | | ", "  \\___/  " } ,
                { "  __     ", " /_ |   ", "  | |    ", "  | |   ", "  | |   ", "  |_|    " },
                { "  ___   ", " |__ \\  ", "    ) | ", "   / /  ", "  / /_  ", " |____| " },
                { "  ____   ", " |___ \\  ", "   __) | ", "  |__ <  ", "  ___) | ", " |____/  " } ,
                { "  _  _   ", " | || |  ", " | || |_ ", " |__   _|", "    | |  ", "    |_|  " } ,
                { "  _____  ", " | ____| ", " | |__   ", " |___ \\  ", "  ___) | ", " |____/  " } ,
                { "    __  ", "   / /  ", "  / /_  ", " | '_ \\ ", " | (_) |", "  \\___/ " } ,
                { "  ______ ", " |____  |", "     / / ", "    / /  ", "   / /   ", "  /_/    " } ,
                { "   ___   ", "  / _ \\  ", " | (_) | ", "  > _ <  ", " | (_) | ", "  \\___/  " } ,
                { "   ___  ", "  / _ \\ ", " | (_) |", "  \\__, |", "    / / ", "   /_/  " }

            };


            string[] seperateur = new string[] { "  ", "  _ ", " (_)", "    ", "  _ ", " (_)" };
            AfficheDigital(number, heure, 25, 10);
            AfficheSeparateur(seperateur, 42, 10);
            AfficheDigital(number, minute, 47, 10);
            AfficheSeparateur(seperateur, 65, 10);
            AfficheDigital(number, seconde, 70, 10);


        }

        static void AfficheSeparateur(string[] separateur, int left, int top)
        {

            for (int i = 0; i < separateur.Length; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.WriteLine(separateur[i]);
            }
        }

        static void AfficheDigital(String[,] number, int valeur, int left, int top)
        {

            int i = 0;
            for (int j = 0; j < number.GetLength(1); j++)
            {
                Console.SetCursorPosition(left, top + j);
                Console.WriteLine(number[(valeur / 10), j]);
                i++;
            }
            for (int j = 0; j < number.GetLength(1); j++)
            {
                Console.SetCursorPosition(left + i + 2, top + j);
                Console.WriteLine(number[(valeur % 10), j]);
            }
        }

        static void AfficheBraille(String[,] number, int valeur, int left, int top)
        {
            for (int j = 0; j < number.GetLength(1); j++)
            {
                Console.SetCursorPosition(left, top + j);
                Console.WriteLine(number[(valeur / 10), j]);
            }
            for (int j = 0; j < number.GetLength(1); j++)
            {
                Console.SetCursorPosition(left + 7 , top + j);
                Console.WriteLine(number[(valeur % 10), j]);
            }
        }

        static void Heure(List<String> pause,String modeleHorloge)
        {

          

            Boolean flag = true;
            Console.CursorVisible = false;

            while (flag)
            {


                string date = DateTime.Now.ToString("H:mm:ss");
                int heure = Int32.Parse(DateTime.Now.ToString("HH"));
                int minute = Int32.Parse(DateTime.Now.ToString("mm"));
                int seconde = Int32.Parse(DateTime.Now.ToString("ss"));

                foreach (var item in pause)
                {
                    if (date.Equals(item))
                    {
                        CancellationTokenSource cts = new CancellationTokenSource();
                        ThreadPool.QueueUserWorkItem(new WaitCallback(TetrisMusic), cts.Token);
                        // // Request cancellation.
                        cts.Cancel(); // ??? sert a qu'elle que chose ?
                        // Console.WriteLine("Fin du thread");             
                        cts.Dispose();
                    }
                }

                
                if (modeleHorloge.ToLower().Equals("digital"))
                {
                    Digital(heure, minute, seconde);
                }
                else if (modeleHorloge.ToLower().Equals("binaire"))
                {
                    Binaire(heure, minute, seconde); Console.SetCursorPosition(50, 5);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(date);
                } else if(modeleHorloge.ToLower().Equals("braille"))
                {
                    
                    Braille(heure, minute, seconde); Console.SetCursorPosition(50, 5);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(date);
                }
                else {
                    flag = !flag;
                    Console.WriteLine("ce modele d'horloge n'existe pas");
                }


               

                //



                Thread.Sleep(1000);




            }
        }
    }
}
