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
        private Graphics graphics;

        /// <summary>
        /// The game's background color
        /// </summary>
        private Color backgroundColor;

        /// <summary>
        /// The size of the world
        /// </summary>
        private Size worldSize;

        /// <summary>
        /// A single GameObject
        /// </summary>
        private GameObject gameObject;

        /// <summary>
        /// Another GameObject
        /// </summary>
        private GameObject tmpGameObject;

        /// <summary>
        /// The GameWorld's constructor
        /// </summary>
        /// <param name="worldSize">The display rectangle's size</param>
        /// <param name="graphics">The graphics device</param>
        public GameWorld(Size worldSize, Graphics graphics)
        {
            // Sets up all the references
            this.worldSize = worldSize;
            this.graphics = graphics;

            // Sets the background color to cornflower blue, this is not used yet.
            backgroundColor = ColorTranslator.FromHtml("#000c41");

            // Creates two GameObjects
            gameObject = new GameObject(graphics, new Point(worldSize.Width / 2, worldSize.Height));
            tmpGameObject = new GameObject(graphics, new Point(60, 100));
        }

        /// <summary>
        /// Updates all our GameObjects
        /// </summary>
        public void Update()
        {
            gameObject.Update();
            tmpGameObject.Update();
        }

    }
}