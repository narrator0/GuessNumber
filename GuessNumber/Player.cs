using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Player
    {
        #region properties

        public int a, b, count = 0;
        private int[] guess = new int[4];
        private int[] number = new int[4];

        //set getter and setter
        public int A
        {
            set { a = value; }
            get { return a; }
        }
        public int B
        {
            set { b = value; }
            get { return b; }
        }
        public int Count
        {
            get { return count; }
        }
        public int[] Guess
        {
            get { return guess; }
        }
        public int[] Number
        {
            get { return number; }
        }

        #endregion


        //add count
        public void add_count()
        {
            count ++;
        }

        //generate random number
        //產生一個亂數(四個位數不能重複)
        public void randget()
        {
            Random rand = new Random();

            do
            {
                int i = 0;
                for (i = 0; i < 4; i++)
                {
                    guess[i] = rand.Next() % 10;
                }
            } while (guess[0] == guess[1] || guess[0] == guess[2] || guess[0] == guess[3]
                || guess[1] == guess[2] || guess[1] == guess[3] || guess[2] == guess[3]);
        }
    }
}
