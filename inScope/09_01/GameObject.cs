using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    class GameObject
    {
        /// <summary>
        /// The GameObject's sprite
        /// </summary>
        private Image sprite;

        /// <summary>
        /// The graphics context
        /// </summary>
        private Graphics graphics;

        /// <summary>
        /// The GameObject's position
        /// </summary>
        private Point position;

        /// <summary>
        /// The GameObject's constructor
        /// </summary>
        /// <param name="graphics">The graphics context</param>
        /// <param name="position">The start position</param>
        public GameObject(Graphics graphics, Point position)
        {
            //Loads the sprite
            this.sprite = Image.FromFile(@"Sprites/player.png");
            //Sets the references
            this.graphics = graphics;
            this.position = position;

            //Moves the sprite into the correct position
            this.position.Y -= sprite.Height;
            this.position.X -= sprite.Width / 2;
        }

        /// <summary>
        /// Updates the GameObject
        /// </summary>
        public void Update()
        {
            //Draws the GameObject
            graphics.DrawImage(sprite, position);
        }
    }
}
