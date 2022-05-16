using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsApp_v2
{
    public partial class Form2 : MaterialForm
    {
        string? mysteryWord;
        int x1;
        int d;
        char[] cn = new char[200];
        int ii = 0;
        int[] pn = new int[200];
        char playerGuess;
        char[] guess = new char[15];
        bool flag;
        //static bool userInputCheck;

        string[] foodlistwords = new string[5];
        string[] countrylistwords = new string[5];
        string[] personlistwords = new string[5];
        string[] gamelistwords = new string[5];
        string[] flowerlistwords = new string[5];
        int gameoption;
        int randomNumberForList;
        string[]? theListWord;

        static string getString(char[] arr)
        {
            // string() is a used to
            // convert the char array
            // to string
            string s = new string(arr);

            return s;
        }
        public Form2(int gameoption)//the constructor
        {
            //game option choose
            this.gameoption = gameoption;
            
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            GameInintialization();
        }
        public void GameInintialization()
        {
            foodlistwords[0] = "burger";
            foodlistwords[1] = "candy";
            foodlistwords[2] = "frenchfry";
            foodlistwords[3] = "mango";
            foodlistwords[4] = "cake";


            countrylistwords[0] = "india";
            countrylistwords[1] = "bangladesh";
            countrylistwords[2] = "srilanka";
            countrylistwords[3] = "bhutan";
            countrylistwords[4] = "maldives";


            gamelistwords[0] = "keram";
            gamelistwords[1] = "cricket";
            gamelistwords[2] = "badminton";
            gamelistwords[3] = "tabletennis";
            gamelistwords[4] = "basketball";


            personlistwords[0] = "messi";
            personlistwords[1] = "ibrahemovyc";
            personlistwords[2] = "eunus";
            personlistwords[3] = "sakib";
            personlistwords[4] = "monir";



            flowerlistwords[0] = "daisy";
            flowerlistwords[1] = "tulip";
            flowerlistwords[2] = "posy";
            flowerlistwords[3] = "ivy";
            flowerlistwords[4] = "clover";

            Random randGen = new Random();
            randomNumberForList = randGen.Next(0, 4); //the random word from the choosen option's list of word

            if (gameoption == 6)
            {
                Application.Exit();

            }
            else if (gameoption == 1)
            {
                headTextBox.Text = "you are playing in mode: Person";
                theListWord = personlistwords;
            }
            else if (gameoption == 2)
            {
                headTextBox.Text = "you are playing in mode: Game";
                theListWord = gamelistwords;
            }
            else if (gameoption == 3)
            {
                headTextBox.Text = "you are playing in mode: Food";
                theListWord = foodlistwords;
            }
            else if (gameoption == 4)
            {
                headTextBox.Text = "you are playing in mode: Country";
                theListWord = countrylistwords;
            }
            else if (gameoption == 5)
            {
                headTextBox.Text = "you are playing in mode: Flower";
                theListWord = flowerlistwords;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            mysteryWord = theListWord[randomNumberForList];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            d = mysteryWord.Length;

            x1 = mysteryWord.Length;

            pictureBox2.Image = imageList1.Images[1];

            for (int p = 0; p < mysteryWord.Length; p++)
            {
                guess[p] = '.';
            }
            output.Text = getString(guess);

        }

        void gameBackend(char playerGuess)
        {
            output.Text = getString(guess);


            for (int i = 97; i < 122; i++)//ascii value of lower case alphabetics
            {
                pn[i] = 0;
                //Console.Write(pn[i]);
            }
      
            
            flag = false;

            for (int j = 0; j < mysteryWord.Length; j++)
            {
                if ((mysteryWord[j] == playerGuess) && (guess[j] != playerGuess))
                {
                    guess[j] = playerGuess;
                    x1--;//length of the right guessed word, to congratulate the player. 
                    pn[(int)playerGuess]++;// mark this ch word in pn array that its already used.
                    niceTry.Text = "RIGHT GUESS!!!";
                    output.Text = getString(guess);
                    pictureBox2.Image = imageList1.Images[1];
                    flag = false;
                    break;
                }
                else if ((mysteryWord[j] == playerGuess) && (guess[j] == playerGuess))
                {
                    flag = true;
                }

            }
            if (flag == true)
            {
                niceTry.Text = "ALREADY USED THAT WORD, USE A DIFFERENT ONE.";
                pictureBox2.Image = imageList1.Images[2];
                //Console.WriteLine("ALREADY USED THAT WORD, USE A DIFFERENT ONE.");
            }


            if (!mysteryWord.Contains(playerGuess))
            {
                pn[(int)playerGuess] += 5;// mark this word in pn array that its already used.

                if (pn[(int)playerGuess] == 5)
                {
                    //deduct a lifespam if the player enters a wrong guess.
                    niceTry.Text = "OOPS! WRONG GUESS, A LIFESPAN HAS BEEN DEDUCTED";
                    pictureBox2.Image = imageList1.Images[2];

                    //Console.WriteLine("OOPS! WRONG GUESS, A LIFESPAN HAS BEEN DEDUCTED");
                    d--;
                    LifeRemaining.Text = "remaining life: "+d.ToString();
                    //Console.WriteLine("Your remain life is {0}", d);
                    pn[(int)playerGuess - 1]++;
                }
                else if (pn[(int)playerGuess] > 5)
                {
                    niceTry.Text = "YOU HAVE ALREADY USED THIS WRONG GUESS.";
                    pictureBox2.Image = imageList1.Images[2];
                    //Console.WriteLine("YOU HAVE ALREADY USED THIS WRONG GUESS.");
                }
            }
             
            if (x1 == 0)
            {
                Form3 f3 = new Form3(mysteryWord, true);
                f3.Show();
                niceTry.Text = "CONGRATULATION WORD MATCHED";
                pictureBox2.Image = imageList1.Images[4];
                //Console.WriteLine("CONGRATULATION WORD MATCHED");
            }
            if (d == 0)
            {
                Form3 f3 = new Form3(mysteryWord,false);
                f3.Show();
                pictureBox2.Image = imageList1.Images[3];
                //"your life is ENDs here"
            }
            ii++;
            
        }//gameBackend



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            gameBackend('b');
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
 
            gameBackend('c');
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            gameBackend('d');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            gameBackend('e');
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            gameBackend('f');
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            gameBackend('g');
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            gameBackend('h');
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            gameBackend('i');
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            gameBackend('j');
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            gameBackend('k');
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            gameBackend('l');
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            gameBackend('m');
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            gameBackend('n');
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            gameBackend('o');
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            gameBackend('p');
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            gameBackend('q');
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            gameBackend('r');
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            gameBackend('s');
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            gameBackend('t');
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            gameBackend('u');
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            gameBackend('v');
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            gameBackend('w');
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            gameBackend('x');
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            gameBackend('y');
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            gameBackend('z');
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            gameBackend('a');
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
