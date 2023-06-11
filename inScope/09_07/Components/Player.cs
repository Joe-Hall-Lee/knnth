using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class Player : Component
    {
        /// <summary>
        /// A reference to the Player's spriterenderer
        /// </summary>
        private SpriteRenderer spriteRenderer;

        /// <summary>
        /// The Player's awake method
        /// </summary>
        public override void Awake()
        {
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("player");
            GameObject.Transform.Position = new Vector2((GameWorld.WorldSize.Width / 2) - (spriteRenderer.Rectangle.Width / 2), (GameWorld.WorldSize.Height) - (spriteRenderer.Rectangle.Height));
        }

        /// <summary>
        /// Overrides the Player's to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Player";
        }
    }
}