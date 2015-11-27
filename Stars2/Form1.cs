///StarField program 
///By Justin Vandersar
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stars2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void StarField(int stars)
        {
            Graphics gpix = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.White);
            Random randNum = new Random();
            for (int i = 0; i <= stars; i++)
            {                
                int x, y, w, r, g, b;

                x = randNum.Next(1, this.Width);
                y = randNum.Next(1, this.Height);
                w = randNum.Next(1, 11);
                r = randNum.Next(0, 256);
                g = randNum.Next(0, 256);
                b = randNum.Next(0, 256);

                brush.Color = Color.FromArgb(r, g, b);

                gpix.FillEllipse(brush, x, y, w, w);
            }
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Graphics gpix = this.CreateGraphics();
            gpix.Clear(Color.White);
            StarField(1000);
            
        }
    }
}
