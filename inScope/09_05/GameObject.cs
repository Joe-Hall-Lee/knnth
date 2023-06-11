using _09_00;
using _09_00.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_02
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
        /// The GameObject's transform
        /// </summary>
        private Transform transform;

        /// <summary>
        /// This dictionary contains all components on this GameObject
        /// </summary>
        private Dictionary<string, Component> components = new Dictionary<string, Component>();

        /// <summary>
        /// The GameObject's constructor
        /// </summary>
        /// <param name="graphics">The graphics context</param>
        /// <param name="position">The start position</param>
        public GameObject(Graphics graphics)
        {
            this.transform = new Transform();

            // Loads the sprite
            this.sprite = Image.FromFile(@"Sprites/player.png");
            // Sets the references
            this.graphics = graphics;


            // Moves the sprite into the correct position
            transform.Position = new Vector2(GameWorld.WorldSize.Width / 2 - sprite.Width / 2, GameWorld.WorldSize.Height - sprite.Height);
        }

        /// <summary>
        /// Adds a component to the GameObject
        /// </summary>
        /// <param name="component"></param>
        public void AddComponent(Component component)
        {
            components.Add(component.ToString(), component);
        }

        /// <summary>
        /// Updates the GameObject
        /// </summary>
        public void Update()
        {
            // if (Keyboard.IsKeyDown(Keys.D))
            // {
            //     position.X += 5;
            // }
            // if (Keyboard.IsKeyDown(Keys.A))
            // {
            //     position.X -= 5;
            // }
            // if (Keyboard.IsKeyDown(Keys.S))
            // {
            //     position.Y += 5;
            // }
            // if (Keyboard.IsKeyDown(Keys.W))
            // {
            //     position.Y -= 5;
            // }

            foreach (Component component in components.Values)
            {
                component.Update();
            }

            // Draws the GameObject
            graphics.DrawImage(sprite,transform.Position.X, transform.Position.Y);
        }
    }
}