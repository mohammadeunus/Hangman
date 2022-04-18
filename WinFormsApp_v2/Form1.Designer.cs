namespace WinFormsApp_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.flowerButton = new System.Windows.Forms.Button();
            this.countryButton = new System.Windows.Forms.Button();
            this.foodButton = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.PersonButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 30);
            this.exitButton.TabIndex = 76;
            this.exitButton.Text = "6.Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // flowerButton
            // 
            this.flowerButton.Location = new System.Drawing.Point(169, 220);
            this.flowerButton.Name = "flowerButton";
            this.flowerButton.Size = new System.Drawing.Size(72, 30);
            this.flowerButton.TabIndex = 75;
            this.flowerButton.Text = "5.Flower.  ";
            this.flowerButton.UseVisualStyleBackColor = true;
            this.flowerButton.Click += new System.EventHandler(this.flowerButton_Click);
            // 
            // countryButton
            // 
            this.countryButton.Location = new System.Drawing.Point(169, 184);
            this.countryButton.Name = "countryButton";
            this.countryButton.Size = new System.Drawing.Size(72, 30);
            this.countryButton.TabIndex = 74;
            this.countryButton.Text = "4.Country. ";
            this.countryButton.UseVisualStyleBackColor = true;
            this.countryButton.Click += new System.EventHandler(this.countryButton_Click);
            // 
            // foodButton
            // 
            this.foodButton.Location = new System.Drawing.Point(89, 256);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(74, 30);
            this.foodButton.TabIndex = 73;
            this.foodButton.Text = "3.Food.    ";
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // GameButton
            // 
            this.GameButton.Location = new System.Drawing.Point(89, 220);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(74, 30);
            this.GameButton.TabIndex = 72;
            this.GameButton.Text = "2.Game.    ";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // PersonButton
            // 
            this.PersonButton.Location = new System.Drawing.Point(89, 184);
            this.PersonButton.Name = "PersonButton";
            this.PersonButton.Size = new System.Drawing.Size(74, 30);
            this.PersonButton.TabIndex = 71;
            this.PersonButton.Text = "1.Person.  ";
            this.PersonButton.UseVisualStyleBackColor = true;
            this.PersonButton.Click += new System.EventHandler(this.PersonButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 33);
            this.label1.TabIndex = 77;
            this.label1.Text = "WELCOME TO THE HANGMAN GAME !!!!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "CHOOSE THE OPTION BELOW YOU WANT TO PLAY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flowerButton);
            this.Controls.Add(this.countryButton);
            this.Controls.Add(this.foodButton);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.PersonButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitButton;
        private Button flowerButton;
        private Button countryButton;
        private Button foodButton;
        private Button GameButton;
        private Button PersonButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}