using System.Diagnostics;
namespace acutalgame
{
    public partial class Form1 : Form
    {
        public string player = "Black";

        public Color playerColor = Color.Black;

        void turnchange()
        {
            if (player == "Black")
            {
                player = "Red";
                playerColor = Color.Red;
            }
            else
            {
                player = "Black";
                playerColor = Color.Black;
            }
        }
        void buttonarray()
        {
            int[,] buttons = new int[10, 8];
            { { } }
        }
        Button selected = null;
        public Form1()
        {
            InitializeComponent();
            SetupForm();




        }

        void Move(object sender, EventArgs e)
        {
            // moving players around 
            Button b = sender as Button;
            Debug.WriteLine(b.BackColor);
            if (selected == null)
            {
                if (b.BackColor == playerColor)
                {
                    selected = sender as Button;
                    return;
                }
                return;
            }

            if (b.BackColor == Color.White)
            {
                Color temp = b.BackColor;
                b.BackColor = selected.BackColor;
                selected.BackColor = temp;
                selected = null;
                turnchange();
            }

        }

        void SetupForm()
        {

            int x = 0;
            int y = 0;
            int p = 0;
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 8; j++)
                {

                    Button button = new Button();
                    button.Click += Move;
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);
                    if (p == 0)
                    {
                        button.BackColor = Color.Black;
                        p = 1;
                    }
                    else if (p == 1)
                    {
                        button.BackColor = Color.White;
                        p = 0;
                    }
                }
                x = 0;
                y = y + (panel1.Height / 8);
                if (p == 1)
                {
                    p = 0;
                }
                else
                {
                    p = 1;
                }
            }
            p = 0;
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Click += Move;
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    button.BackColor = Color.White;
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);

                }
                x = 0;
                y = y + (panel1.Height / 8);
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Click += Move;
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);
                    if (p == 1)
                    {
                        button.BackColor = Color.Red;
                        p = 0;
                    }
                    else if (p == 0)
                    {
                        button.BackColor = Color.White;
                        p = 1;
                    }
                }
                x = 0;
                y = y + (panel1.Height / 8);
                if (p == 1)
                {
                    p = 0;
                }
                else
                {
                    p = 1;
                }
            }
            label1.Text = "player 1 score:";
            label2.Text = "player 2 score:";
        
        
        
        }

        
    }
}
