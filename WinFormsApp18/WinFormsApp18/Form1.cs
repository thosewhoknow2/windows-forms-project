namespace WinFormsApp18
{
    public partial class epiccheckers : Form
    {
        public epiccheckers()
        {
            InitializeComponent();

            Image red = Image.FromFile("checkers red .png");
            Image black = Image.FromFile("checkers black.png");
            pictureBox1.Image = red;
            
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
