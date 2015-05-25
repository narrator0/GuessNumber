﻿namespace GuessNumber
{
    partial class Form_Game
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.game_name = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.game_panel = new System.Windows.Forms.Panel();
            this.quit_button = new System.Windows.Forms.Button();
            this.computer_result_box = new System.Windows.Forms.RichTextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.commend = new System.Windows.Forms.Label();
            this.man_result_box = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.result_panel = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            this.panel_rule = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rule_title = new System.Windows.Forms.TextBox();
            this.button_goback = new System.Windows.Forms.Button();
            this.button_rule = new System.Windows.Forms.Button();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.game_panel.SuspendLayout();
            this.result_panel.SuspendLayout();
            this.panel_rule.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_name
            // 
            this.game_name.AutoSize = true;
            this.game_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.game_name.Location = new System.Drawing.Point(220, 100);
            this.game_name.Name = "game_name";
            this.game_name.Size = new System.Drawing.Size(149, 31);
            this.game_name.TabIndex = 1;
            this.game_name.Text = "猜數字遊戲";
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_Button.Location = new System.Drawing.Point(241, 171);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(102, 33);
            this.Start_Button.TabIndex = 2;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // game_panel
            // 
            this.game_panel.Controls.Add(this.quit_button);
            this.game_panel.Controls.Add(this.computer_result_box);
            this.game_panel.Controls.Add(this.button_reset);
            this.game_panel.Controls.Add(this.richTextBox2);
            this.game_panel.Controls.Add(this.commend);
            this.game_panel.Controls.Add(this.man_result_box);
            this.game_panel.Controls.Add(this.button2);
            this.game_panel.Controls.Add(this.button3);
            this.game_panel.Controls.Add(this.button4);
            this.game_panel.Controls.Add(this.button5);
            this.game_panel.Controls.Add(this.button6);
            this.game_panel.Controls.Add(this.button7);
            this.game_panel.Controls.Add(this.button8);
            this.game_panel.Controls.Add(this.button9);
            this.game_panel.Controls.Add(this.button0);
            this.game_panel.Controls.Add(this.button1);
            this.game_panel.Controls.Add(this.confirm);
            this.game_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_panel.Location = new System.Drawing.Point(0, 0);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(600, 400);
            this.game_panel.TabIndex = 3;
            this.game_panel.TabStop = true;
            this.game_panel.Visible = false;
            // 
            // quit_button
            // 
            this.quit_button.Location = new System.Drawing.Point(399, 318);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(138, 35);
            this.quit_button.TabIndex = 1;
            this.quit_button.Text = "QUIT";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // computer_result_box
            // 
            this.computer_result_box.Enabled = false;
            this.computer_result_box.Location = new System.Drawing.Point(399, 124);
            this.computer_result_box.Name = "computer_result_box";
            this.computer_result_box.Size = new System.Drawing.Size(138, 173);
            this.computer_result_box.TabIndex = 2;
            this.computer_result_box.Text = "";
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_reset.Location = new System.Drawing.Point(54, 304);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(132, 23);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox2.Location = new System.Drawing.Point(54, 90);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox2.Size = new System.Drawing.Size(132, 25);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Guess Number";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // commend
            // 
            this.commend.AutoSize = true;
            this.commend.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.commend.ForeColor = System.Drawing.Color.Red;
            this.commend.Location = new System.Drawing.Point(305, 82);
            this.commend.Name = "commend";
            this.commend.Size = new System.Drawing.Size(168, 16);
            this.commend.TabIndex = 0;
            this.commend.Text = "由你先猜，請輸入數字";
            // 
            // man_result_box
            // 
            this.man_result_box.Enabled = false;
            this.man_result_box.Location = new System.Drawing.Point(255, 124);
            this.man_result_box.Name = "man_result_box";
            this.man_result_box.Size = new System.Drawing.Size(138, 173);
            this.man_result_box.TabIndex = 1;
            this.man_result_box.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(100, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(146, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(54, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(100, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(146, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(54, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(100, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(146, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 1;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button0.Location = new System.Drawing.Point(54, 258);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 40);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(54, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirm.Location = new System.Drawing.Point(100, 258);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(86, 40);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // result_panel
            // 
            this.result_panel.Controls.Add(this.result_textbox);
            this.result_panel.Controls.Add(this.button_save);
            this.result_panel.Controls.Add(this.button_restart);
            this.result_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_panel.Location = new System.Drawing.Point(0, 0);
            this.result_panel.Name = "result_panel";
            this.result_panel.Size = new System.Drawing.Size(600, 400);
            this.result_panel.TabIndex = 0;
            this.result_panel.TabStop = true;
            this.result_panel.Visible = false;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_save.Location = new System.Drawing.Point(248, 193);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(102, 38);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_restart
            // 
            this.button_restart.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.button_restart.Location = new System.Drawing.Point(250, 149);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(102, 38);
            this.button_restart.TabIndex = 0;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // panel_rule
            // 
            this.panel_rule.BackColor = System.Drawing.SystemColors.Control;
            this.panel_rule.Controls.Add(this.richTextBox1);
            this.panel_rule.Controls.Add(this.rule_title);
            this.panel_rule.Controls.Add(this.button_goback);
            this.panel_rule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rule.Location = new System.Drawing.Point(0, 0);
            this.panel_rule.Name = "panel_rule";
            this.panel_rule.Size = new System.Drawing.Size(600, 400);
            this.panel_rule.TabIndex = 1;
            this.panel_rule.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(42, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(481, 151);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "玩家與電腦互相在心中設定0~9的四個數字，且四個數字不能重複，然後互相猜測對方的數字。若猜測的數字中有一個數字相同且位置也正確的話就回答1A，若只有數字相同則回答" +
    "1B。例如如果數字是1234，那猜1354，就應該回答 2A1B。最後由猜最少次的人勝出。";
            // 
            // rule_title
            // 
            this.rule_title.BackColor = System.Drawing.SystemColors.Control;
            this.rule_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rule_title.Enabled = false;
            this.rule_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rule_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rule_title.Location = new System.Drawing.Point(222, 56);
            this.rule_title.Name = "rule_title";
            this.rule_title.Size = new System.Drawing.Size(100, 26);
            this.rule_title.TabIndex = 1;
            this.rule_title.Text = "規則說明";
            this.rule_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_goback
            // 
            this.button_goback.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_goback.Location = new System.Drawing.Point(380, 318);
            this.button_goback.Name = "button_goback";
            this.button_goback.Size = new System.Drawing.Size(138, 35);
            this.button_goback.TabIndex = 1;
            this.button_goback.Text = "BACK";
            this.button_goback.UseVisualStyleBackColor = true;
            this.button_goback.Click += new System.EventHandler(this.botton_goback_Click);
            // 
            // button_rule
            // 
            this.button_rule.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_rule.Location = new System.Drawing.Point(241, 214);
            this.button_rule.Name = "button_rule";
            this.button_rule.Size = new System.Drawing.Size(102, 33);
            this.button_rule.TabIndex = 2;
            this.button_rule.Text = "Rule";
            this.button_rule.UseVisualStyleBackColor = true;
            this.button_rule.Click += new System.EventHandler(this.button_rule_Click);
            // 
            // result_textbox
            // 
            this.result_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_textbox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result_textbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.result_textbox.Location = new System.Drawing.Point(250, 104);
            this.result_textbox.Multiline = true;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(100, 27);
            this.result_textbox.TabIndex = 1;
            this.result_textbox.Text = "LOSE";
            this.result_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.result_panel);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.button_rule);
            this.Controls.Add(this.game_name);
            this.Controls.Add(this.panel_rule);
            this.Name = "Form_Game";
            this.Text = " Guess Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            this.result_panel.ResumeLayout(false);
            this.result_panel.PerformLayout();
            this.panel_rule.ResumeLayout(false);
            this.panel_rule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_name;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.RichTextBox man_result_box;
        private System.Windows.Forms.Label commend;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.RichTextBox computer_result_box;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Panel result_panel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Button button_rule;
        private System.Windows.Forms.Panel panel_rule;
        private System.Windows.Forms.TextBox rule_title;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_goback;
        private System.Windows.Forms.TextBox result_textbox;
    }
}

