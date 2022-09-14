namespace PictureBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picBestGame_Click(object sender, EventArgs e)
        {

        }

        private void btn1st_Click(object sender, EventArgs e)
        {
            picBestGame.Visible = true;
            picSecondBest.Visible = false;
            picThirdBest.Visible = false;
        }

        private void btn2nd_Click(object sender, EventArgs e)
        {
            picSecondBest.Visible = true;
            picBestGame.Visible = false;
            picThirdBest.Visible = false;
        }

        private void btn3rd_Click(object sender, EventArgs e)
        {
            picThirdBest.Visible = true;
            picBestGame.Visible = false;
            picSecondBest.Visible = false;
        }
    }
}