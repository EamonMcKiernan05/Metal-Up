using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true; //stops image flickering
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Pen currentpen = new Pen(Color.Black);
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Point a = new Point(20, 30);
            Point b = new Point(400, 500);
            gr.DrawLine(currentpen, a, b);

        }
    }
}
