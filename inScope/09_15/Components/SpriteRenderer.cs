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
        /// Scales the visual representation of the sprite
        /// </summary>
        public float ScaleFactor { get; set; } = 1;

        /// <summary>
        /// Indicates if this GameObject is invisible
        /// </summary>
        private bool isVisible;

        /// <summary>
        /// Rectangle for drawing the sprite
        /// </summary>
        public RectangleF Rectangle
        {
            get {
                return new RectangleF(GameObject.Transform.Position.X,
              GameObject.Transform.Position.Y,
              sprite.Width * ScaleFactor, sprite.Height* ScaleFactor); }
        }

        public Image Sprite
        {
            get
            {
                return sprite;
            }
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

            if (GameWorld.Debug) //Draw the collision boxes if debug is enabled
            {
                graphics.DrawRectangle(new Pen(Color.Red, 0.5f), new Rectangle((int)Rectangle.X, (int)Rectangle.Y, (int)Rectangle.Width, (int)Rectangle.Height));
            }
           
        }

        /// <summary>
        /// Overrides the sprites to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "SpriteRenderer";
        }

        /// <summary>
        /// Indicates if a gameobject becomes invisible
        /// </summary>
        /// <returns>True if it has become invisible</returns>
        public bool OnBecameInvisible()
        {
            if (isVisible)
            {
                if (   GameObject.Transform.Position.Y < -Rectangle.Height
                    || GameObject.Transform.Position.Y > GameWorld.WorldSize.Height
                    || GameObject.Transform.Position.X < -Rectangle.Width
                    || GameObject.Transform.Position.X > GameWorld.WorldSize.Width
                   )
                {
                    isVisible = false;
                    return true;
                }
   

            }
            isVisible = true;
            return false;
        }



    }
}
