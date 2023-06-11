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
        /// <summary>
        /// The GameObject variable
        /// </summary>
        private GameObject gameObject;

        public Form1()
        {
            InitializeComponent();
            //Calculates the bottom center position
            Point position = new Point(DisplayRectangle.Width / 2, DisplayRectangle.Height);

            //Instantiates the GameObject
            gameObject = new GameObject(CreateGraphics(), position);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Updates the GameObject
            gameObject.Update();
        }
    }
}
