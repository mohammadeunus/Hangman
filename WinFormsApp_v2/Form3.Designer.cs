namespace WinFormsApp_v2
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.GAMEOVER = new System.Windows.Forms.Label();
            this.mystryWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GAMEOVER
            // 
            this.GAMEOVER.AutoSize = true;
            this.GAMEOVER.Font = new System.Drawing.Font("Rosewood Std Regular", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GAMEOVER.Location = new System.Drawing.Point(60, 70);
            this.GAMEOVER.Name = "GAMEOVER";
            this.GAMEOVER.Size = new System.Drawing.Size(170, 37);
            this.GAMEOVER.TabIndex = 1;
            this.GAMEOVER.Text = "game over";
            this.GAMEOVER.Click += new System.EventHandler(this.label1_Click);
            // 
            // mystryWord
            // 
            this.mystryWord.AutoSize = true;
            this.mystryWord.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mystryWord.Location = new System.Drawing.Point(60, 119);
            this.mystryWord.Name = "mystryWord";
            this.mystryWord.Size = new System.Drawing.Size(117, 23);
            this.mystryWord.TabIndex = 2;
            this.mystryWord.Text = "the mystry word is";
            this.mystryWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mystryWord.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 291);
            this.Controls.Add(this.mystryWord);
            this.Controls.Add(this.GAMEOVER);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label GAMEOVER;
        private Label mystryWord;
    }
}