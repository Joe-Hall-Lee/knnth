using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class Laser : Component
    {
        /// <summary>
        /// The Laser's spriterenderer
        /// </summary>
        private SpriteRenderer spriteRenderer;

        /// <summary>
        /// The Laser's movement speed
        /// </summary>
        private float speed;

        /// <summary>
        /// The laser's sprite name
        /// </summary>
        private string laserSprite;

        /// <summary>
        /// The direction that this laser will travel in
        /// </summary>
        private Vector2 direction;

        /// <summary>
        /// The Lasers spawn position
        /// </summary>
        private Vector2 startPos;

        /// <summary>
        /// Constructor for the laser
        /// </summary>
        /// <param name="laserSprite">Name of the laser sprite</param>
        /// <param name="direction">The laser's direction</param>
        /// <param name="startPos">The laser's spawn position</param>
        public Laser(string laserSprite, Vector2 direction, Vector2 startPos)
        {
            this.laserSprite = laserSprite;
            this.direction = direction;
            this.startPos = startPos;
        }

        /// <summary>
        /// The laser's awake method, this method is used to set up everything
        /// </summary>
        public override void Awake()
        {
            speed = 300;
            GameObject.Transform.Position = startPos;
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite(laserSprite);
            spriteRenderer.ScaleFactor = 0.7f;
        }

        /// <summary>
        /// Updates the laser
        /// </summary>
        public override void Update()
        {
            Move();

            // Checks if the laser has become invisibe.
            if (spriteRenderer.OnBecameInvisible())
            {
                GameWorld.Destroy(GameObject);
            }
        }

        /// <summary>
        /// Makes the laser move in a specific direction
        /// </summary>
        public void Move()
        {
            GameObject.Transform.Translate(direction * speed * MyTime.DeltaTime);
        }
    }
}