using MaterialSkin;
using MaterialSkin.Controls;
namespace WinFormsApp_v2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public int gameOption;

        private void buttonQ_Click(object sender, EventArgs e)
        {
            gameOption = 1;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            gameOption = 6;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();
        }

        private void flowerButton_Click(object sender, EventArgs e)
        {
            gameOption = 5;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();
        }

        private void countryButton_Click(object sender, EventArgs e)
        {
            gameOption = 4;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            gameOption = 3;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            gameOption = 2;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();
        }
        private void PersonButton_Click(object sender, EventArgs e)
        {
            gameOption = 1;
            Form2 gf = new Form2(gameOption);
            gf.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}