using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_00
{
    public partial class Form1 : Form
    {
        private Image sprite;
        public Form1()
        {
            InitializeComponent();
            sprite = Image.FromFile(@"Sprites/player.png");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(sprite, 200, 100);
        }
    }
}