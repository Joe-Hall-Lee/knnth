using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_02
{
    public partial class Form1 : Form
    {
        private GameWorld gameWorld;

        public Form1()
        {
            InitializeComponent();

            gameWorld = new GameWorld(DisplayRectangle,CreateGraphics());
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            gameWorld.Update();
        }
    }
}
