using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeos
{
    class Logic:ILogic
    {
        int tryCount { get; set; }
        byte input { get; set; }
        int num { get; set; }
        public void Controller()
        {
            tryCount = 6;
            StartGame();
        }

        private void StartGame()
        {
            num = GenerateNum();
            Console.WriteLine("Kompiuterma Chaifiqra Ricxvi 1-dan 99-is chatvlit,Scadet Misi Gamocnoba");
            MainLogic();
            Controller();
        }

        private void MainLogic()
        {
            while (tryCount !=0)
            {
                if (Byte.TryParse(Console.ReadLine(), out byte temp))
                    input = temp;
                else
                {
                    Console.WriteLine("Dasashvebia Mxolod Mteli Ricxvebi");
                    return;
                }
                string compared="";
                if (input < num)
                    compared = "Metia";
                else if (input > num)
                    compared = "Naklebia";
                else
                    Guessed();
                Console.WriteLine("Chafiqrebuli Ricxvi {0} Shetanil Ricxvze,Darchenilia {1} cda",compared,--tryCount);
            }
            Console.WriteLine("Samwuxarod Tqven Ver Gamoicanit Ricxvi,Es Ricxvi Iyo {0} Scadet Tavidan",num);
            GameOver();
        }

        private void Guessed()
        {
            Console.WriteLine(@"Gilocavt! Tqven Gamoicanit Chafiqrebuli Ricxvi Da Amisatvis Dagchirdat {0} Cda",7-tryCount);
            GameOver();
        }

        private void GameOver()
        {
            Console.WriteLine("Tavidan Dasawyebad Chaweret 1,Dasaxurad 0");
            if (Console.ReadLine() == "1")
                Controller();
            Environment.Exit(1);
        }

        private int GenerateNum()
        {
            Random rnd = new Random();
            return rnd.Next(1, 99);
        }
    }
}
