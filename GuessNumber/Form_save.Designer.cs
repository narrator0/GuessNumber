namespace GuessNumber
{
    partial class Form_save
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name_input = new System.Windows.Forms.Label();
            this.label_record = new System.Windows.Forms.Label();
            this.button_save_confirm = new System.Windows.Forms.Button();
            this.button_save_false = new System.Windows.Forms.Button();
            this.textBox_name_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name_input
            // 
            this.label_name_input.AutoSize = true;
            this.label_name_input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name_input.Location = new System.Drawing.Point(13, 86);
            this.label_name_input.Name = "label_name_input";
            this.label_name_input.Size = new System.Drawing.Size(138, 21);
            this.label_name_input.TabIndex = 0;
            this.label_name_input.Text = "請輸入你的名字：";
            // 
            // label_record
            // 
            this.label_record.AutoSize = true;
            this.label_record.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_record.Location = new System.Drawing.Point(45, 122);
            this.label_record.Name = "label_record";
            this.label_record.Size = new System.Drawing.Size(106, 21);
            this.label_record.TabIndex = 1;
            this.label_record.Text = "你的紀錄是：";
            // 
            // button_save_confirm
            // 
            this.button_save_confirm.Location = new System.Drawing.Point(157, 184);
            this.button_save_confirm.Name = "button_save_confirm";
            this.button_save_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_save_confirm.TabIndex = 2;
            this.button_save_confirm.Text = "Save";
            this.button_save_confirm.UseVisualStyleBackColor = true;
            this.button_save_confirm.Click += new System.EventHandler(this.button_save_confirm_Click);
            // 
            // button_save_false
            // 
            this.button_save_false.Location = new System.Drawing.Point(39, 184);
            this.button_save_false.Name = "button_save_false";
            this.button_save_false.Size = new System.Drawing.Size(75, 23);
            this.button_save_false.TabIndex = 3;
            this.button_save_false.Text = "Back";
            this.button_save_false.UseVisualStyleBackColor = true;
            this.button_save_false.Click += new System.EventHandler(this.button_save_false_Click);
            // 
            // textBox_name_input
            // 
            this.textBox_name_input.Location = new System.Drawing.Point(157, 85);
            this.textBox_name_input.Name = "textBox_name_input";
            this.textBox_name_input.Size = new System.Drawing.Size(100, 22);
            this.textBox_name_input.TabIndex = 4;
            this.textBox_name_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_name_input);
            this.Controls.Add(this.button_save_false);
            this.Controls.Add(this.button_save_confirm);
            this.Controls.Add(this.label_record);
            this.Controls.Add(this.label_name_input);
            this.Name = "Form_save";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_input;
        private System.Windows.Forms.Label label_record;
        private System.Windows.Forms.Button button_save_confirm;
        private System.Windows.Forms.Button button_save_false;
        private System.Windows.Forms.TextBox textBox_name_input;
    }
}