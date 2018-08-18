namespace TicTacTow
{
    partial class Form1
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
            this.Playe1_Button = new System.Windows.Forms.Button();
            this.Player2_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Playe1_Button
            // 
            this.Playe1_Button.BackColor = System.Drawing.Color.Cyan;
            this.Playe1_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Playe1_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playe1_Button.ForeColor = System.Drawing.Color.DarkCyan;
            this.Playe1_Button.Location = new System.Drawing.Point(645, 97);
            this.Playe1_Button.Name = "Playe1_Button";
            this.Playe1_Button.Size = new System.Drawing.Size(150, 76);
            this.Playe1_Button.TabIndex = 0;
            this.Playe1_Button.Text = "Player1 -- X";
            this.Playe1_Button.UseVisualStyleBackColor = false;
            this.Playe1_Button.Click += new System.EventHandler(this.Playe1_Button_Click);
            // 
            // Player2_button
            // 
            this.Player2_button.BackColor = System.Drawing.Color.MediumPurple;
            this.Player2_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Player2_button.FlatAppearance.BorderSize = 10;
            this.Player2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_button.ForeColor = System.Drawing.Color.Indigo;
            this.Player2_button.Location = new System.Drawing.Point(645, 227);
            this.Player2_button.Name = "Player2_button";
            this.Player2_button.Size = new System.Drawing.Size(150, 76);
            this.Player2_button.TabIndex = 1;
            this.Player2_button.Text = "Player2 -- O";
            this.Player2_button.UseVisualStyleBackColor = false;
            this.Player2_button.Click += new System.EventHandler(this.Player2_button_Click);
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.LightGreen;
            this.Start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.Start_button.Location = new System.Drawing.Point(633, 355);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(177, 98);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Start!!!";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(220, 474);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 45);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(955, 567);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Player2_button);
            this.Controls.Add(this.Playe1_Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playe1_Button;
        private System.Windows.Forms.Button Player2_button;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

