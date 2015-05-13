namespace GuessNumber
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
            this.game_pamel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // game_name
            // 
            this.game_name.AutoSize = true;
            this.game_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.game_name.Location = new System.Drawing.Point(220, 100);
            this.game_name.Name = "game_name";
            this.game_name.Size = new System.Drawing.Size(149, 31);
            this.game_name.TabIndex = 0;
            this.game_name.Text = "猜數字遊戲";
            this.game_name.Click += new System.EventHandler(this.game_name_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_Button.Location = new System.Drawing.Point(241, 171);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(102, 33);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // game_pamel
            // 
            this.game_pamel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_pamel.Location = new System.Drawing.Point(0, 0);
            this.game_pamel.Name = "game_pamel";
            this.game_pamel.Size = new System.Drawing.Size(600, 400);
            this.game_pamel.TabIndex = 2;
            this.game_pamel.Visible = false;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.game_pamel);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.game_name);
            this.Name = "Form_Game";
            this.Text = "Guess Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_name;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Panel game_pamel;
    }
}

