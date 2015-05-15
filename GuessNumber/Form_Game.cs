using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GuessNumber
{
    public partial class Form_Game : Form
    {
        private Player computer = new Player(), player = new Player();
        private bool manguessing = true;
        private string show_guess_num;
        private List<string> show_guess_result;
        private int count_num = 0;
        private int[] man_guess = new int[4];
        private string text_man_result_box = "玩家\n";
        private string text_computer_result_box = "電腦\n";

        public Form_Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //無法將 computer.Number 傳遞，所以只能這樣做
            int[] temp = new int[4];
            Game_Controller.randget(ref temp);
            Array.Copy(temp, computer.Number, 4);

            reset();

            //set search
            Game_Controller.set_search();

            //rich box setting
            man_result_box.Text = text_man_result_box;
            computer_result_box.Text = text_computer_result_box;
        }

        private void game_name_Click(object sender, EventArgs e)
        {
        }

        //go to game mode
        private void Start_Button_Click(object sender, EventArgs e)
        {
            //change to game mode
            game_pamel.Visible = true;    
        }

        private void ShowNum()
        {
            if (manguessing)
                richTextBox2.Text = show_guess_num;
            else
            {
                if(count_num != 0)
                    show_guess_result.Remove("?");

                if (count_num == 2)
                    show_guess_result.Reverse();
                richTextBox2.Text = show_guess_result[1] + "A" + show_guess_result[0] + "B";   
            }

            man_result_box.Text = text_man_result_box;
            computer_result_box.Text = text_computer_result_box;
        }

        //
        //number buttons
        //
        private void button0_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "0";
                count_num ++;
                ShowNum();
            }
            else if (count_num != 2 && !manguessing)
            {
                show_guess_result.Add("0");
                count_num ++;
                ShowNum();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "1";
                count_num++;
                ShowNum();
            }
            else if (count_num != 2 && !manguessing)
            {
                show_guess_result.Add("1");
                count_num++;
                ShowNum();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "2";
                count_num++;
                ShowNum();
            }
            else if (count_num != 2 && !manguessing)
            {
                show_guess_result.Add("2");
                count_num++;
                ShowNum();
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "3";
                count_num++;
                ShowNum();
            }
            else if (count_num != 2 && !manguessing)
            {
                show_guess_result.Add("3");
                count_num++;
                ShowNum();
            }     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "4";
                count_num++;
                ShowNum();
            }
            else if (count_num != 2 && !manguessing)
            {
                show_guess_result.Add("4");
                count_num++;
                ShowNum();
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "5";
                count_num++;
                ShowNum();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "6";
                count_num++;
                ShowNum();
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "7";
                count_num++;
                ShowNum();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "8";
                count_num++;
                ShowNum();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "9";
                count_num++;
                ShowNum();
            }
            
        }


        //things to do when confirm in man guess mode
        private void confirm_man_guessing(string origin)
        {
            //pass in man guess
            char[] origin_char = origin.ToCharArray(0, 4);
            for (int k = 0; k < 4; k++)
            {
                player.Guess[k] = (int)char.GetNumericValue(origin_char[k]);
            }

            //get a and b
            int[] temp = new int[4];
            Array.Copy(player.Guess, temp, 4);
            int a = 0, b = 0;
            Game_Controller.get_ab(temp, computer.Number, ref a, ref b);
            player.A = a;
            player.B = b;

            //create computer guess
            if (player.count == 0)
            {
                computer.randget();
            }
            else
            {
                int[] bot_guess = new int[4];
                Game_Controller.setbotguess(computer.Guess, computer.A, computer.B, ref bot_guess);
                Array.Copy(bot_guess, computer.Guess, 4);
            }

            //set rich box
            text_man_result_box += (show_guess_num + " =>" + player.A + "A" + player.B + "B\n");
            for (int i = 0; i < 4; i++)
            {
                text_computer_result_box += computer.Guess[i];
            }

            player.add_count();
        }

        //things to do when confirm in computer guess mode
        private void confirm_computer_guessing()
        {
            //pass in result
            computer.A = int.Parse(show_guess_result[1]);
            computer.B = int.Parse(show_guess_result[0]);

            //set guess
            int[] bot_guess = new int[4];
            Game_Controller.setbotguess(computer.Guess, computer.A, computer.B,ref bot_guess);

            for (int k = 0; k < 4; k++)
            {
                player.Guess[k] = bot_guess[k];
            }

            text_computer_result_box += " =>" + show_guess_result[1] + "A" + show_guess_result[0] + "B\n";
        }
         

        private void confirm_Click(object sender, EventArgs e)
        {
            if (manguessing)
            {
                confirm_man_guessing(show_guess_num);

                commend.Text = "電腦猜了，請回應";
            }
            else
            {
                confirm_computer_guessing();

                commend.Text = "又輪到你了";
            }

            manguessing = !manguessing;
            reset();
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
            ShowNum();       
        }

        //reset
        private void reset()
        {
            //reset list
            show_guess_result = new List<string>();
            show_guess_result.Add("?");
            show_guess_result.Add("?");

            //reset string
            show_guess_num = " ";

            //reset count
            count_num = 0;

            ShowNum();
        }

        private void quit_button_Click(object sender, EventArgs e)
        {

        }
    }
}
