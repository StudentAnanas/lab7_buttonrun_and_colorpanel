using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorPanel
{
    public partial class Form1 : Form
    {
        static int valueR = 125;
        static int valueG = 125;
        static int valueB = 125;
        string myColor = "#000000";
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor= Color.FromArgb(valueR, valueG, valueB);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = pictureBox1.BackColor;
            
            byte g = color.G;
            byte b = color.B;
            byte r = color.R;
            myColor = $"#{r:X2}{g:X2}{b:X2}";
            toolTip1.SetToolTip(pictureBox1,$"Ваш цвет: "+myColor); 
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            valueR = trackBar2.Value;
            pictureBox1.BackColor = Color.FromArgb(valueR, valueG, valueB);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            valueG = trackBar3.Value;
            pictureBox1.BackColor = Color.FromArgb(valueR, valueG, valueB);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            valueB = trackBar4.Value;
            pictureBox1.BackColor = Color.FromArgb(valueR, valueG, valueB);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(myColor);
        }
    }
}
