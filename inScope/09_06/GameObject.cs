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
        /// The GameObject's transform
        /// </summary>
        public Transform Transform { get; private set; }

        /// <summary>
        /// This dictionary contains all components on this GameObject
        /// </summary>
        private Dictionary<string, Component> components = new Dictionary<string, Component>();

        /// <summary>
        /// The GameObject's constructor
        /// </summary>
        /// <param name="graphics">The graphics context</param>
        /// <param name="position">The start position</param>
        public GameObject()
        {
            this.Transform = new Transform();
        }

        /// <summary>
        /// Adds a component to the GameObject
        /// </summary>
        /// <param name="component"></param>
        public void AddComponent(Component component)
        {
            components.Add(component.ToString(), component);
            component.GameObject = this;
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

        }
    }
}