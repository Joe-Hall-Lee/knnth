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
    public class GameObject
    {
        /// <summary>
        /// The GameObject's transform
        /// </summary>
        public Transform Transform { get; private set; }

        /// <summary>
        /// This dictionary contains all components on this GameObject
        /// </summary>
        private Dictionary<string, Component> components = new Dictionary<string, Component>();

        public string Tag { get; set; }

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

        public Component GetComponent(string component)
        {
            return components[component];
        }

        public void Awake()
        {
            foreach (Component component in components.Values)
            {
                component.Awake();
            }
        }

        public void Start()
        {
            foreach (Component component in components.Values)
            {
                if (component.IsEnabled)
                {
                    component.Start();
                }
               
            }
        }

        /// <summary>
        /// Updates the GameObject
        /// </summary>
        public void Update()
        {
            foreach (Component component in components.Values)
            {
                if (component.IsEnabled)
                {
                    component.Update();
                }
            }
        }

        /// <summary>
        /// Destroyes the GameObject and all its components from the game
        /// </summary>
        public void Destroy()
        {
            foreach (Component component in components.Values)
            {
                component.Destory();
            }

            GameWorld.Destroy(this);
        }
    }
}