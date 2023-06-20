using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Zadanie3
{
    public partial class UserControl1 : UserControl
    {
        Bitmap bitmap = new Bitmap(Image.FromFile("Свое изображение"));
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, 0, 0, Width, Height); //Создаем белый прямоугольник, во всю область.
            g.DrawImage(bitmap, 10, 10, trackBar1.Value, trackBar2.Value); //Поверх прямоугольника выводим изображение.
        }
    }
}
