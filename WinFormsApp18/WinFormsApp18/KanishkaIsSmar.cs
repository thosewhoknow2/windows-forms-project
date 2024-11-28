using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class epiccheckers : Form
    {
        Image k = Image.FromFile("checkers black.png");


        public epiccheckers()
        {
            InitializeComponent();
            int x = 0;
            int y = 0;
            int p = 0;
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 8; j++)
                {

                    Button button = new Button();
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    panel1.Controls.Add(button);
                    button.BackColor = Color.Red;
                    x = x + (panel1.Width / 8);
                }
                x = 0;
                y = y + (panel1.Height / 8);
                panel1.BackgroundImage = k;
            }
            for (int i = 0; i < 4; i++)

            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);

                }
                x = 0;
                y = y + (panel1.Height / 8);
            }
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 8; j++)
                {
                    if (p == 1)
                    {
                        button.BackColor= Color.Black;
                        p = 0;
                    }
                    if (p == 0)
                    {
                        button.BackColor= Color.White;  
                        p = 1;
                    }
        --
                    
                    
                    Button button = new Button();
                    button.Size = new Size(panel1.Width / 8, panel1.Height / 8);
                    button.Location = new Point(x, y);
                    
                    panel1.Controls.Add(button);
                    x = x + (panel1.Width / 8);

                }
                x = 0;
                y = y + (panel1.Height / 8);
                p = 0;
            }
        }
    }
}
