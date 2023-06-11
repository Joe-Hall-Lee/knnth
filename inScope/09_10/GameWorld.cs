using _09_00;
using _09_00.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _09_02
{
    class GameWorld
    {
        /// <summary>
        /// Property for accessing the graphics device contex
        /// </summary>
        public static Graphics Graphics { get; private set; }

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
        private List<GameObject> gameObjects = new List<GameObject>();

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
            Graphics = backBuffer.Graphics;

            // Sets the background color to cornflower blue, this is not used yet.
            backgroundColor = ColorTranslator.FromHtml("#000c41");

            Initialize();
        }

        /// <summary>
        /// Initializes the game
        /// </summary>
        private void Initialize()
        {
            // Creates a player GameObject
            GameObject player = new GameObject();
            player.AddComponent(new SpriteRenderer());
            player.AddComponent(new Player());
            gameObjects.Add(player);

            GameObject enemy = new GameObject();
            enemy.AddComponent(new SpriteRenderer());
            enemy.AddComponent(new Enemy());
            gameObjects.Add(enemy);

            Awake();
            Start();
        }

        /// <summary>
        /// Calls Awake on all GameObjects
        /// </summary>
        private void Awake()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Awake();
            }
        }

        /// <summary>
        /// Calls star on all GameObjects
        /// </summary>
        private void Start()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Start();
            }
        }

        /// <summary>
        /// Updates all our GameObjects
        /// </summary>
        public void Update()
        {
            MyTime.CalcDeltaTime();

            Graphics.Clear(backgroundColor);

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }

            backBuffer.Render();
        }

    }
}