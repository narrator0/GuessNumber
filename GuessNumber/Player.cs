using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Player
    {
        private int a, b, count = 0;
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

        //add count
        public void add_count()
        {
            count ++;
        }
    }
}
