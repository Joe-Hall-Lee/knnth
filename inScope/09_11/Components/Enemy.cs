using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class Enemy : Component
    {
        /// <summary>
        /// The enemy's spriterenderer
        /// </summary>
        private SpriteRenderer spriteRenderer;

        /// <summary>
        /// The Enemy's movement speed
        /// </summary>
        private float speed;

        /// <summary>
        /// Generates random numbers
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// The Enemy's awake method
        /// </summary>
        public override void Awake()
        {
            speed = 100;
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("enemy_01");
            spriteRenderer.ScaleFactor = 0.7f;
        }

        /// <summary>
        /// Updates the enemy
        /// </summary>
        public override void Update()
        {
            Move();
            ScreenBounds();
        }

        /// <summary>
        /// Moves the enemy based on input
        /// </summary>
        private void Move()
        {
            // Moves the Enemy
            GameObject.Transform.Translate(new Vector2(0, 1) * speed * MyTime.DeltaTime);
        }

        /// <summary>
        /// Checks if the enemy is outside the bounds on the screen
        /// </summary>
        private void ScreenBounds()
        {
            if (GameObject.Transform.Position.Y > GameWorld.WorldSize.Height)
            {
                Reset();
            }
        }

        /// <summary>
        /// Resets the enemy
        /// </summary>
        private void Reset()
        {
            int x = random.Next(0, (int)(GameWorld.WorldSize.Width - spriteRenderer.Rectangle.Width));
            GameObject.Transform.Position = new Vector2(x, -spriteRenderer.Rectangle.Height);
        }
    }
}