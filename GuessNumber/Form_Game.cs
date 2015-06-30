using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace GuessNumber
{
    public partial class Form_Game : Form
    {
        #region properties

        private Player computer = new Player(), player = new Player();
        private Game_Controller main_control;
        private bool manguessing = true;
        private string show_guess_num;
        private List<char> show_guess_result;
        private int count_num = 0;
        private int count_down = 8;
        private int[] man_guess = new int[4];
        private string text_man_result_box = "玩家\n";
        private string text_computer_result_box = "電腦\n";
        private bool is_auto = false, number_entered = false;
        enum gamestate
        {
            unknown, lose, win, same
        };
        private gamestate state = gamestate.unknown;

        enum mode
        {
            vs, only
        };
        private mode mode_controll;

        #endregion


        #region main_form

        //load
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

            //init controller
            main_control = new Hard_Game_Controller();
        }

        //initialize
        public Form_Game()
        {
            InitializeComponent();
        }

        //go to game mode(start button)
        private void Start_Button_Click(object sender, EventArgs e)
        {
            //change to game mode
            game_panel.Visible = true;
            mode_controll = mode.vs;

            //set auto AB 
            if (is_auto)
                commend.Text = "請先輸入你的數字";
        }


        private void button_start_guess_only_Click(object sender, EventArgs e)
        {
            game_panel.Visible = true;
            mode_controll = mode.only;

            //前設定
            commend.Text = "請輸入數字";
            computer_result_box.Visible = false;
            textBox_count_down.Visible = true;
            man_result_box.Location = new System.Drawing.Point(280, 124);
        }


        //go to rule page
        private void button_rule_Click(object sender, EventArgs e)
        {
            panel_rule.Visible = true;
        }

        //button_goback (from panel_rule)
        private void botton_goback_Click(object sender, EventArgs e)
        {
            panel_rule.Visible = false;
        }

        //go to settings
        private void button_setting_Click(object sender, EventArgs e)
        {
            panel_setting.Visible = true;
        }

        #endregion


        #region game_panel


        #region buttons
        /// <summary>
        ///buttons
        /// </summary>
        private void button0_Click(object sender, EventArgs e)
        {
            if (count_num != 4 && manguessing)
            {
                show_guess_num += "0";
                count_num++;
                ShowNum();
            }
            else if (count_num != 2 && !manguessing)
            {
                show_guess_result.Add('0');
                count_num++;
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
                show_guess_result.Add('1');
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
                show_guess_result.Add('2');
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
                show_guess_result.Add('3');
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
                show_guess_result.Add('4');
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

        //confirm button
        private void confirm_Click(object sender, EventArgs e)
        {
            if (mode_controll == mode.vs)
                confirm_vs_mode();
            else if (mode_controll == mode.only)
                confirm_only_mode();
        }

        //quit button
        private void quit_button_Click(object sender, EventArgs e)
        {
            state = gamestate.lose;
            show_result_panel();
        }

        //reset button
        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
            ShowNum();
        }

        #endregion


        #region methods and logic

        ///<summary>
        ///methods and logic
        ///</summary>>

        //confirm_only_mode
        private void confirm_only_mode()
        {
            if (test_input(show_guess_num))
            {
                MessageBox.Show("輸入有誤，請重新輸入!");
            }
            else
            {
                //get a and b
                int[] temp = new int[4];
                Array.Copy(player.Guess, temp, 4);
                int a = 0, b = 0;
                Game_Controller.get_ab(temp, computer.Number, ref a, ref b);
                player.A = a;
                player.B = b;

                //set rich box
                text_man_result_box += (show_guess_num + " =>" + player.A + "A" + player.B + "B\n");

                player.add_count();
                count_down--;
            }

            //判斷勝負
            if (count_down == 0)
            {
                state = gamestate.lose;
                show_result_panel();
            }
            if (player.A == 4)
            {
                state = gamestate.win;
                show_result_panel();
            }
            

            reset();

            if (is_auto)
            {
                if (count_num != 0)
                    show_guess_result.Remove('?');

                if (count_num == 2)
                    show_guess_result.Reverse();
                richTextBox2.Text = show_guess_result[1] + "A" + show_guess_result[0] + "B";
            }
        }

        //confirm_vs_mode
        private void confirm_vs_mode()
        {
           

            if (test_input(show_guess_num))
            {
                MessageBox.Show("輸入有誤，請重新輸入!");
            }
            else if (!number_entered && is_auto)
            {
                enter_number();
            }
            else
            {
                if (manguessing)
                {
                    confirm_man_guessing();
                    if (player.count == 1)
                        creat_computer_geuss();

                    if (is_auto)
                    {
                        int a = 0, b = 0;
                        Game_Controller.get_ab(computer.Guess, player.Number, ref a, ref b);
                        computer.A = a;
                        computer.B = b;

                        computer.add_count();

                                
                        text_computer_result_box += " =>" + show_guess_result[1] + "A" + show_guess_result[0] + "B\n";

                        //set guess
                        creat_computer_geuss();
                    }

                    //set rich box
                    for (int i = 0; i < 4; i++)
                    {
                        text_computer_result_box += computer.Guess[i];
                    }

                }
                else
                {
                    confirm_computer_guessing();
                    if (player.A == 4)
                    {
                        //set rich box
                        for (int i = 0; i < 4; i++)
                        {
                            text_computer_result_box += computer.Guess[i];
                        }
                    }
                }

                if (!computer.Guess_right && !player.Guess_right && !is_auto)
                    manguessing = !manguessing;

                bool test = (computer.Guess[0] == 0 && computer.Guess[1] == 0 && computer.Guess[2] == 0 && computer.Guess[3] == 0);
                if (test && (manguessing || player.A == 4))
                {
                    MessageBox.Show("你給的A與B有誤，所以你輸了!!");

                    state = gamestate.lose;
                    show_result_panel();
                }

                //record win (避免玩家先猜到且電腦也在同次猜到但會宣告玩家贏的bug)
                if (computer.A == 4)
                    computer.Guess_right = true;
                if (player.A == 4)
                    player.Guess_right = true;

                //game over 
                if (computer.Guess_right || (computer.Guess_right && player.Guess_right))
                {
                    if (player.count < computer.count)
                        state = gamestate.win;
                    else if (computer.A == 4 && player.A != 4)
                        state = gamestate.lose;
                    else
                        state = gamestate.same;

                    show_result_panel();
                }

            }

            reset();
        }

        //enter number for autoguess
        private void enter_number()
        {
            player.set_Number(show_guess_num);
            number_entered = true;

            commend.Text = "由你先猜，請輸入數字";
        }

        //show richtextbox2, man_result_box and computer_result_box
        private void ShowNum()
        {
            if (manguessing)
                richTextBox2.Text = show_guess_num;
            else
            {
                if (count_num != 0)
                    show_guess_result.Remove('?');

                if (count_num == 2)
                    show_guess_result.Reverse();
                richTextBox2.Text = show_guess_result[1] + "A" + show_guess_result[0] + "B";
            }

            man_result_box.Text = text_man_result_box;
            computer_result_box.Text = text_computer_result_box;

            //set richTextBox
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;

            //set count_down
            textBox_count_down.Text = count_down.ToString();
        }

        //things to do when confirm in man guess mode
        private void confirm_man_guessing()
        {
            //get a and b
            int[] temp = new int[4];
            Array.Copy(player.Guess, temp, 4);
            int a = 0, b = 0;
            Game_Controller.get_ab(temp, computer.Number, ref a, ref b);
            player.A = a;
            player.B = b;

            //set rich box
            text_man_result_box += (show_guess_num + " =>" + player.A + "A" + player.B + "B\n");

            player.add_count();

            if (computer.A != 4)
                commend.Text = "電腦猜了，請回應";

        }

        //creat computer guess
        private void creat_computer_geuss()
        {
            //create computer guess
            if (player.count == 1 && computer.count == 0)
            {
                computer.randget();
            }
            else
            {
                int[] bot_guess = new int[4];

                main_control.setbotguess(computer.Guess, computer.A, computer.B, computer.count, ref bot_guess);
                Array.Copy(bot_guess, computer.Guess, 4);
            }


        }

        //things to do when confirm in computer guess mode
        private void confirm_computer_guessing()
        {
            //pass in result
            computer.A = (int)char.GetNumericValue(show_guess_result[1]);
            computer.B = (int)char.GetNumericValue(show_guess_result[0]);
            
            
            text_computer_result_box += " =>" + show_guess_result[1] + "A" + show_guess_result[0] + "B\n";

            computer.add_count();

            //set guess
            creat_computer_geuss();

            if (player.A != 4)
                commend.Text = "又輪到你了";
        }

        //test input when confirm
        private bool test_input(string origin)
        {
            bool is_wrong;
            if (manguessing)
            {
                if (count_num != 4)
                    return true;

                //pass in man guess
                char[] origin_char = origin.ToCharArray(1, 4);
                for (int k = 0; k < 4; k++)
                {
                    player.Guess[k] = (int)char.GetNumericValue(origin_char[k]);
                }
                int manguess = 1000 * player.Guess[0] + 100 * player.Guess[1] + 10 * player.Guess[2] + player.Guess[3];

                is_wrong = (manguess < 0 || manguess > 9999 || player.Guess[0] == player.Guess[1]
                || player.Guess[1] == player.Guess[2] || player.Guess[1] == player.Guess[3]
                || player.Guess[2] == player.Guess[3]);
            }
            else
            {
                if (count_num != 2)
                    return true;

                int a_plus_b = (int)char.GetNumericValue(show_guess_result[0]) + (int)char.GetNumericValue(show_guess_result[1]);

                is_wrong = (a_plus_b > 4 || a_plus_b < 0);
            }

            return is_wrong;
        }

        //reset
        private void reset()
        {
            //reset list
            show_guess_result = new List<char>();
            show_guess_result.Add('?');
            show_guess_result.Add('?');

            //reset string
            show_guess_num = " ";

            //reset count
            count_num = 0;

            ShowNum();
        }

        //show result_panel
        private void show_result_panel()
        {
            game_panel.Visible = false;

            switch (state)
            {
                case gamestate.unknown:
                    break;
                case gamestate.lose:
                    result_textbox.Text = "LOSE";
                    break;
                case gamestate.same:
                    result_textbox.Text = "平手";
                    break;
                case gamestate.win:
                    result_textbox.Text = "WIN";
                    break;
            }
                

            result_panel.Visible = true;
        }

        //control keyboard inout
        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //數字才要反應
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                if (manguessing && count_num < 4)
                {
                    show_guess_num += e.KeyChar.ToString();
                    count_num++;
                    ShowNum();
                }
                else if (e.KeyChar >= 48 && e.KeyChar <= 52 && count_num < 2)
                {
                    show_guess_result.Add(e.KeyChar);
                    count_num++;
                    ShowNum();
                }
            }

            //不能直接顯示打的字
            e.Handled = true;

        }

        //處理enter and delete
        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (mode_controll == mode.vs)
                    confirm_vs_mode();
                else if (mode_controll == mode.only)
                    confirm_only_mode();
            }
            else if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }


        #endregion


        #endregion


        #region result_panel

        //restart button
        private void button_restart_Click(object sender, EventArgs e)
        {
            reset_all();
            result_panel.Visible = false;
        }

        private void reset_all()
        {
            manguessing = true;
            //reset all
            player = new Player();
            computer = new Player();
            text_computer_result_box = "電腦\n";
            text_man_result_box = "玩家\n";
            if (is_auto)
            {
                commend.Text = "請先輸入你的數字";
            }
            else
                commend.Text = "由你先猜，請輸入數字";
            computer.Guess_right = false;
            player.Guess_right = false;
            state = gamestate.unknown;
            count_down = 8;

            //無法將 computer.Number 傳遞，所以只能這樣做
            int[] temp = new int[4];
            Game_Controller.randget(ref temp);
            Array.Copy(temp, computer.Number, 4);

            //set search
            Game_Controller.set_search();

            //reset view
            computer_result_box.Visible = true;
            textBox_count_down.Visible = false;
            man_result_box.Location = new System.Drawing.Point(255, 124);

            reset();

        }


        #endregion


        #region panel_setting


        private void button_back_Click(object sender, EventArgs e)
        {
            panel_setting.Visible = false;
        }

        private void radioButton_normal_CheckedChanged(object sender, EventArgs e)
        {
            main_control = new Normal_Game_Controller();
        }

        private void radioButton_easy_CheckedChanged(object sender, EventArgs e)
        {
            main_control = new Easy_Game_Controller();
        }

        private void radioButton_hard_CheckedChanged(object sender, EventArgs e)
        {
            main_control = new Hard_Game_Controller();
        }

         private void radioButton_on_CheckedChanged(object sender, EventArgs e)
        {
            is_auto = true;
        }

        private void radioButton_off_CheckedChanged(object sender, EventArgs e)
        {
            is_auto = false;
        }
        #endregion

    }
}