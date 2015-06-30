using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessNumber;

namespace UnitTest_GuessNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_get_ab1()
        {
            int[] guess_num = { 1, 3, 5, 7 };
            int[] real_num = { 2, 1, 4, 7 };
            int a = 0, b = 0;

            Game_Controller.get_ab(guess_num, real_num, ref a, ref b);

            Assert.AreEqual(a, 1);
            Assert.AreEqual(b, 1);
        }

        [TestMethod]
        public void TestMethod_get_ab2()
        {
            int[] guess_num = {0, 3, 2, 9};
            int[] real_num = { 1, 4, 2, 7 };
            int a = 0, b = 0;

            Game_Controller.get_ab(guess_num, real_num, ref a, ref b);

            Assert.AreEqual(a, 1);
            Assert.AreEqual(b, 0);
        }

        [TestMethod]
        public void TestMethod_set_bot_guess()
        {
            int[] real_num = { 2, 5, 7, 9 };
            int[] lastguess = { 1, 2, 3, 4 };
            int[] guess = new int[4];
            int[] test1 = { 0, 1, 5, 6 };
            int[] test2 = { 2, 0, 7, 8 };
            int a = 0, b = 0;

            Game_Controller.set_search();
            Game_Controller game = new Hard_Game_Controller();

            Game_Controller.get_ab(lastguess, real_num, ref a, ref b);
            game.setbotguess(lastguess, a, b, 0, ref guess);
            Array.Copy(guess, lastguess, 4);

            CollectionAssert.AreEqual(test1, guess);

            Game_Controller.get_ab(lastguess, real_num, ref a, ref b);
            game.setbotguess(lastguess, a, b, 0, ref guess);
            Array.Copy(guess, lastguess, 4);

            CollectionAssert.AreEqual(test2, guess);

            Game_Controller.get_ab(lastguess, real_num, ref a, ref b);
            game.setbotguess(lastguess, a, b, 0, ref guess);
            Array.Copy(guess, lastguess, 4);

            CollectionAssert.AreEqual(real_num, guess);

        }
    }
}
