﻿using System;
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
        public Form_Game()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void game_name_Click(object sender, EventArgs e)
        {
        }


        //triggered event
        private void Start_Button_Click(object sender, EventArgs e)
        {
            game_pamel.Visible = true;    
        }


    }
}