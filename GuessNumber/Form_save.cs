using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessNumber
{
    public partial class Form_save : Form
    {
        public Form_save()
        {
            InitializeComponent();
        }

        private void button_save_false_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //save record to record.txt
        private void button_save_confirm_Click(object sender, EventArgs e)
        {

            StreamReader read = new StreamReader("record.txt");
            string count = read.ReadLine();
            read.Close();

            StreamWriter save = new StreamWriter("record.txt", true);
            
            save.WriteLine(textBox_name_input.Text + "\b" + count);
            save.Close();

            this.Close();
        }
    }
}
