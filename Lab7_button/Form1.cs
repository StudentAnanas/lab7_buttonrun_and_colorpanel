using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_button
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Point cur = this.PointToClient(Cursor.Position);
            Point loc = button1.Location;
            int x_new = loc.X;
            int y_new = loc.Y;

            //Движение вправо
            if (cur.X < loc.X + button1.Width)
                x_new += 10;

            //Движение влево
            if (cur.X + 10 > loc.X + button1.Width)
                x_new -= 10;

            //Движение вверх
            if (cur.Y + 10 > loc.Y + button1.Height)
                y_new -= 10;

            //Движение вниз
            if (cur.Y < loc.Y + button1.Height)
                y_new += 10;
            
            //Отступ слева
            if (x_new < 5)
                x_new = 5;

            //Отступ справа
            if (x_new > panel1.Width - button1.Width - 25)
                x_new = panel1.Width - button1.Width - 25;

            //Отступ сверху
            if (y_new < 10)
                y_new = 10;

            //Отступ снизу
            if (y_new > panel1.Height - button1.Height - 45)
                y_new = panel1.Height - button1.Height - 45;

            //курсор внизу формы
            if (y_new > panel1.Height - button1.Height - 50)
                y_new = panel1.Height - button1.Height - 80;

            //курсор вверху формы
            if (y_new < 11)
                y_new += 50;

            //курсор справа формы
            if (x_new > panel1.Width - button1.Width - 26)
                x_new += -100;

            //курсор слева формы
            if (x_new < 6)
                x_new += 100;

            button1.Location = new Point(x_new, y_new);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Left = this.ClientSize.Width / 2 - button1.Width / 2;
            button1.Top = this.ClientSize.Height / 2 - button1.Height / 2;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int x_new = button1.Location.X;
            int y_new = button1.Location.X;
            bool f = false;
            //Отступ слева
            if (x_new < 5)
            {
                f = true;
                x_new = 5;
            }


            //Отступ справа
            if (x_new > panel1.Width - button1.Width - 100) { x_new = panel1.Width - button1.Width - 25; f = true; }


            //Отступ сверху
            if (y_new < 10) { y_new = 10; f = true; }


            //Отступ снизу
            if (y_new > panel1.Height - button1.Height - 100) { y_new = panel1.Height - button1.Height - 45; f = true; }

            if (f == true)
                button1.Location = new Point(x_new, y_new);
          
        }

        private void button1_ParentChanged(object sender, EventArgs e)
        {
            int x_new = button1.Location.X;
            int y_new = button1.Location.X;
            
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
