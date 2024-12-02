using System.Diagnostics;
using System.Windows.Forms.ComponentModel.Com2Interop;
namespace acutalgame
{
    public partial class Form1 : Form
    {
        public string player = "Black";

        public Color playerColor = Color.Black;

        public int playerblackscore = 0;

        List<Button> buttoncity = new List<Button>();

        public int[] buttontown = new int[100];

        public int playerredscore = 0;
        void playerscores()
        {
            if (playerblackscore == 12) 
            {
                
            }
            if (playerredscore == 12)
            {

            }
        }
        void turnchange()
        {
            
            if (player == "Black")
            {
                player = "Red";
                playerColor = Color.Red;
                label3.Text = "Red";
            }
            else
            {
                player = "Black";
                playerColor = Color.Black;
                label3.Text = "black";
            }
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
            if (player == "Black")
            {
                if (selected == null)
                {
                    if (b.BackColor == playerColor)
                    {
                        selected = sender as Button;
                        return;
                    }
                    return;
                }

                if (int.Parse(b.Name) == int.Parse(selected.Name) + 7)
                { 
                    if (b.BackColor == Color.PaleGreen)
                    {
                        Color temp = b.BackColor;
                        b.BackColor = selected.BackColor;
                        selected.BackColor = temp;
                        selected = null;
                        turnchange();
                    }
                }
                else
                {
                    if (int.Parse(b.Name) == int.Parse(selected.Name) + 9)
                    {
                        if (b.BackColor == Color.PaleGreen)
                        {
                            Color temp = b.BackColor;
                            b.BackColor = selected.BackColor;
                            selected.BackColor = temp;
                            selected = null;
                            turnchange();
                        }
                    }
                }
                
                
            }
            if (player == "Red")
            {
                if (selected == null)
                {
                    if (b.BackColor == playerColor)
                    {
                        selected = sender as Button;
                        return;
                    }
                    return;
                }
                if (int.Parse(b.Name) == int.Parse(selected.Name) - 7)
                {
                    if (b.BackColor == Color.PaleGreen)
                    {
                        Color temp = b.BackColor;
                        b.BackColor = selected.BackColor;
                        selected.BackColor = temp;
                        selected = null;
                        turnchange();
                    }
                }
                else
                {
                    if (int.Parse(b.Name) == int.Parse(selected.Name) - 9)
                    {
                        if (b.BackColor == Color.PaleGreen)
                        {
                            Color temp = b.BackColor;
                            b.BackColor = selected.BackColor;
                            selected.BackColor = temp;
                            selected = null;
                            turnchange();
                        }
                    }
                }
            }
        }

        void SetupForm()
        {
            //creates all the buttons and adds the buttons to a list 
            int buttonnum = 0;
            int x = 0;
            int y = 0;
            int p = 0;
            int row = 0;
            int colum = 0;
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 8; j++)
                {

                    Button button = new Button();
                    button.Click += Move;
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    button.Name = buttonnum.ToString();
                    buttontown[buttonnum] = int.Parse(button.Name);
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);
                    buttoncity.Add(button);
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
                    buttonnum++;
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
                    button.Name = buttonnum.ToString();
                    buttontown[buttonnum] = int.Parse(button.Name);
                    x = x + (panel1.Width / 8);
                    buttoncity.Add(button);
                    if (p == 1)
                    {
                        button.BackColor = Color.PaleGreen;
                        p = 0;
                    }
                    else if (p == 0)
                    {
                        button.BackColor = Color.White;
                        p = 1;
                    }
                    buttonnum++;
                }
                if (p == 1)
                {
                    p = 0;
                }
                else
                {
                    p = 1;
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
                    button.Name = buttonnum.ToString();
                    buttontown[buttonnum] = int.Parse(button.Name);
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);
                    buttoncity.Add(button);
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
                    buttonnum++;
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
            
            label1.Text = "player 1 score: " + playerredscore;
            label2.Text = "player 2 score: " + playerblackscore;
            label3.Text = "black";

            foreach (int a in buttontown)
            {
                label3.Text += a + ", ";
            }
            
        }
        

        
    }
}
