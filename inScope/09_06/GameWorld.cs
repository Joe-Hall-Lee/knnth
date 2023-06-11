using _09_00.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02
{
    class GameWorld
    {
        /// <summary>
        /// A reference to the graphics device
        /// </summary>
        private Graphics dc;

        private BufferedGraphics backBuffer;

        /// <summary>
        /// The game's background color
        /// </summary>
        private Color backgroundColor;

        /// <summary>
        /// The size of the world
        /// </summary>
        public static Size WorldSize { get; private set; }

        /// <summary>
        /// A single GameObject
        /// </summary>
        private GameObject gameObject;

        /// <summary>
        /// The GameWorld's constructor
        /// </summary>
        /// <param name="worldSize">The display rectangle's size</param>
        /// <param name="graphics">The graphics device</param>
        public GameWorld(Rectangle displayRectangle, Graphics graphics)
        {
            // Sets up all the references
            WorldSize = displayRectangle.Size;
            
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            this.dc = backBuffer.Graphics;

            // Sets the background color to cornflower blue, this is not used yet.
            backgroundColor = ColorTranslator.FromHtml("#000c41");


            // Creates a player GameObject
            gameObject = new GameObject();

            SpriteRenderer sr = new SpriteRenderer(dc);
            sr.SetSprite("player");

            gameObject.AddComponent(sr);
            
        }

        /// <summary>
        /// Updates all our GameObjects
        /// </summary>
        public void Update()
        {
            dc.Clear(backgroundColor);

            gameObject.Update();

            backBuffer.Render();
        }

    }
}