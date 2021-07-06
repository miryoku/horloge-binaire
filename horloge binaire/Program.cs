using System;
using System.Threading;

namespace horloge_binaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {


                string date = DateTime.Now.ToString("H:mm:ss");
                int heure = Int32.Parse(DateTime.Now.ToString("HH"));
                int minute = Int32.Parse(DateTime.Now.ToString("mm"));
                int seconde = Int32.Parse(DateTime.Now.ToString("ss"));
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
                Console.SetCursorPosition(50, 5);
                Console.WriteLine(date);
                Affiche(falgH,0);
                Affiche(falgM,1);
                Affiche(falgS,2);
                Console.SetCursorPosition(0, 0);
                Thread.Sleep(100);
            }
        }





        static void Affiche(Boolean[] flag,int ligne)
        {

            String[] s = new string[] { "┌───────┐", "│       │", "│       │", "│       │", "└───────┘" };

            for (int i = 0; i < s.Length; i++)
            {
                Console.SetCursorPosition(30, 10+(ligne * 5) + i);
                for (int j = 0; j < flag.Length; j++)
                {
                    if (flag[j]) { Console.BackgroundColor = ConsoleColor.DarkGreen; } else Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(s[i]);
                }
                

            }
        }
    }
}
