using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Game_Controller
    {
        //產生一個亂數(四個位數不能重複)
        public static void randget(ref int[] gnum)
        {
            int[] cut = new int[4];
            Random rand = new Random();

            do
            {
                int i = 0;
                for (i = 0; i < 4; i++)
                {
                    cut[i] = rand.Next() % 10;
                }
            } while (cut[0] == cut[1] || cut[0] == cut[2] || cut[0] == cut[3] 
                || cut[1] == cut[2] || cut[1] == cut[3] || cut[2] == cut[3]);
            gnum = cut;
        }

        //get the result of a and b
        public static void get_ab(int[] firstnum, int[] secondnum, ref int a, ref int b)
        {
            int i = 0, j = 0;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    if (firstnum[i] != secondnum[j])
                        continue;
                    if (i == j)
                        a++;
                    else
                        b++;
                }
        }

        //set the search array
        private bool[, , ,] search = new bool[10, 10, 10, 10];

        //set getter and setter
        public bool[, , ,] Search
        {
            get { return search; }
        }

        //初始化設定 將有沒有重複數字的設置為true
        public Game_Controller()
        {
            int a = 0, b = 0, c = 0, d = 0;
            for (a = 0; a < 10; a++)
                for (b = 0; b < 10; b++)
                    for (c = 0; c < 10; c++)
                        for (d = 0; d < 10; d++)
                        {
                            if (a == b || a == c || a == d || b == c || b == d || c == d)
                                continue;
                            search[a, b, c, d] = true;
                        }
        }

        //設定猜測
        public void setbotguess(int[] guessnum, int aresult, int bresult, ref int[] botguess)
        {
            botguess = new int[4];
            bool get_answer = false;

            //將不可能的選項設置為否
            int a = 0, b = 0, c = 0, d = 0;
            for (a = 0; a < 10; a++)
                for (b = 0; b < 10; b++)
                    for (c = 0; c < 10; c++)
                        for (d = 0; d < 10; d++)
                        {
                            //排除已經是否的
                            if (search[a, b, c, d] == false)
                                continue;

                            //找到所有可能的選項
                            int[] botnum = { a, b, c, d };
                            int testa = 0, testb = 0;
                            get_ab(guessnum, botnum, ref testa, ref testb);

                            //將第一個找到的值作為電腦猜測
                            if (testa == aresult && testb == bresult && !get_answer)
                            {
                                Array.Copy(botnum, botguess, 4);
                                get_answer = true;
                            }

                            //排除還成立的
                            if (testa == aresult && testb == bresult)
                                continue;
                                
                            //將不可能的數字設為false
                            search[a, b, c, d] = false;
                        }
        }

    }
}
