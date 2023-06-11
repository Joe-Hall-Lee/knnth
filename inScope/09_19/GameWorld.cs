using _09_00;
using _09_00.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

        public static bool Debug { get; set; } = false;

        /// <summary>
        /// A single GameObject
        /// </summary>
        private static List<GameObject> gameObjects = new List<GameObject>();

        /// <summary>
        /// The GameWorld's constructor
        /// </summary>
        /// <param name="worldSize">The display rectangle's size</param>
        /// <param name="graphics">The graphics device</param>
        public GameWorld(Rectangle displayRectangle, Graphics graphics)
        {
            //Sets up all the references
            WorldSize = displayRectangle.Size;
            
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            Graphics = backBuffer.Graphics;

            //Sets the background color to cornflower blue, this is not used yet.
            backgroundColor = ColorTranslator.FromHtml("#000c41");

            Initialize();
        }

        /// <summary>
        /// Initializes the game
        /// </summary>
        private void Initialize()
        {
            //Creates a player GameObject
            GameObject player = new GameObject();
            player.AddComponent(new SpriteRenderer(2));
            player.AddComponent(new Player());
            player.AddComponent(new Collider());
            player.AddComponent(new Animator());
            gameObjects.Add(player);

            GameObject enemy = new GameObject();
            enemy.AddComponent(new SpriteRenderer(1));
            enemy.AddComponent(new Enemy());
            enemy.AddComponent(new Collider());
            enemy.AddComponent(new Animator());
            gameObjects.Add(enemy);

            GameObject background1 = new GameObject();
            GameObject background2 = new GameObject();
            GameObject background3 = new GameObject();


            background1.AddComponent(new Background("BG1", Vector2.Zero, 20, background3.Transform));
            background1.AddComponent(new SpriteRenderer());
            gameObjects.Add(background1);

         
            background2.AddComponent(new Background("BG2", new Vector2(0,-768), 20, background1.Transform));
            background2.AddComponent(new SpriteRenderer());
            gameObjects.Add(background2);

            background3.AddComponent(new Background("BG3", new Vector2(0,-768*2), 20, background2.Transform));
            background3.AddComponent(new SpriteRenderer());
            gameObjects.Add(background3);

            GameObject smoke = new GameObject();
            smoke.AddComponent(new SpriteRenderer());
            smoke.AddComponent(new BackgroundElement("space-smoke_01"));
            gameObjects.Add(smoke);

            GameObject planet = new GameObject();
            planet.AddComponent(new SpriteRenderer());
            planet.AddComponent(new BackgroundElement("planet_01"));
            gameObjects.Add(planet);
        

            gameObjects.Sort();
            Awake();
            Start();
        }

        /// <summary>
        /// Calls Awake on all GameObjects
        /// </summary>
        private void Awake()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Awake();
            }
        }

        /// <summary>
        /// Calls star on all GameObjects
        /// </summary>
        private void Start()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Start();
            }
        }

        /// <summary>
        /// Updates all our GameObjects
        /// </summary>
        public void Update()
        {
            MyTime.CalcDeltaTime();

            Graphics.Clear(backgroundColor);

            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }

            backBuffer.Render();
        }

        /// <summary>
        /// Instantiates a new GameObject in the GameWorld
        /// </summary>
        /// <param name="go"></param>
        public static void Instantiate(GameObject go)
        {
            go.Awake();
            go.Start();
            gameObjects.Add(go);
            gameObjects.Sort();
        }

        /// <summary>
        /// Removes a GameObject from the GameWorld
        /// </summary>
        /// <param name="go"></param>
        public static void Destroy(GameObject go)
        {
            gameObjects.Remove(go);
        }

    }
}
