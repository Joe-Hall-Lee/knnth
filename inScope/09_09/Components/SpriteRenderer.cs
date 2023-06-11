using _09_02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class SpriteRenderer : Component
    {
        /// <summary>
        /// A reference to the graphics device context
        /// </summary>
        private Graphics graphics;

        /// <summary>
        /// The sprite that this renderer displays
        /// </summary>
        private Image sprite;

        /// <summary>
        /// Rectangle for drawing the sprite
        /// </summary>
        public RectangleF Rectangle
        {
            get {
                return new RectangleF(GameObject.Transform.Position.X,
              GameObject.Transform.Position.Y,
              sprite.Width, sprite.Height); }
        }

        /// <summary>
        /// The sprite's constructor
        /// </summary>
        public SpriteRenderer()
        {
            this.graphics = GameWorld.Graphics;
        }

        /// <summary>
        /// Loads the sprite by name
        /// </summary>
        /// <param name="spriteName"></param>
        public void SetSprite(string spriteName)
        {
            this.sprite = Image.FromFile($@"Sprites/{spriteName}.png");
        }

        /// <summary>
        /// Draws the sprite on the screen
        /// </summary>
        public override void Update()
        {
            graphics.DrawImage(sprite, Rectangle);
        }

        /// <summary>
        /// Overrides the sprites to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "SpriteRenderer";
        }



    }
}
