using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_00.Components
{
    class Player : Component
    {
        /// <summary>
        /// A reference to the Player's spriterenderer
        /// </summary>
        private SpriteRenderer spriteRenderer;

        private Animator animator;

        private Vector2 velocity;

        private float speed;

        private bool canShoot;

        private float timeSinceLastShot;

        private float shootCoolDown = 1;

        /// <summary>
        /// The Player's awake method
        /// </summary>
        public override void Awake()
        {

            GameObject.Tag = "Player";
            speed = 100;
            canShoot = true;
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("player");
            spriteRenderer.ScaleFactor = 0.7f;

            animator = (Animator)GameObject.GetComponent("Animator");
            animator.AddAnimation(new Animation("PlayerFly", 10));
            animator.PlayAnimation("PlayerFly");
            GameObject.Transform.Position = new Vector2((GameWorld.WorldSize.Width / 2) - (spriteRenderer.Rectangle.Width / 2), (GameWorld.WorldSize.Height) - (spriteRenderer.Rectangle.Height));
        }

        /// <summary>
        /// Updates the player
        /// </summary>
        public override void Update()
        {
            GetInput();
            Move();
            ScreenLimits();
            ScreenWarp();
            HandleShootCooldown();
        }

        private void HandleShootCooldown()
        {
            if (!canShoot)
            {
                timeSinceLastShot += MyTime.DeltaTime;
            }
            if (timeSinceLastShot >= shootCoolDown)
            {
                canShoot = true;
            }
        }

        /// <summary>
        /// Get's the playes input
        /// </summary>
        private void GetInput()
        {
            velocity = Vector2.Zero;

            if (Keyboard.IsKeyDown(Keys.W))
            {
                velocity += new Vector2(0, -1);
            }
            if (Keyboard.IsKeyDown(Keys.A))
            {
                velocity += new Vector2(-1, 0);
            }
            if (Keyboard.IsKeyDown(Keys.S))
            {
                velocity += new Vector2(0, 1);
            }
            if (Keyboard.IsKeyDown(Keys.D))
            {
                velocity += new Vector2(1, 0);
            }
            if (Keyboard.IsKeyDown(Keys.Space))
            {
                Shoot();
            }


            //Normalizes the vector to make sure that we don't move faster diagonally
            velocity = Vector2.Normalize(velocity);
        }

        /// <summary>
        /// Moves the player based on input
        /// </summary>
        private void Move()
        {
            //Moves the player
            GameObject.Transform.Translate(velocity * speed * MyTime.DeltaTime);
        }

        /// <summary>
        /// Overrides the Player's to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Player";
        }

        private void Shoot()
        {
            if (canShoot)
            {
                canShoot = false;
                timeSinceLastShot = 0;
                GameObject laser = new GameObject();
                Vector2 spawnPos = new Vector2(GameObject.Transform.Position.X + (spriteRenderer.Rectangle.Width / 2) - 3, GameObject.Transform.Position.Y - 18f);
                laser.AddComponent(new Laser("laser", new Vector2(0, -1), spawnPos));
                laser.AddComponent(new SpriteRenderer(1));
                laser.AddComponent(new Collider());
                GameWorld.Instantiate(laser);
            }

        }

        private void ScreenWarp()
        {
            if (GameObject.Transform.Position.X + spriteRenderer.Sprite.Width < 0)
            {
                GameObject.Transform.Position = new Vector2(GameWorld.WorldSize.Width + spriteRenderer.Sprite.Width, GameObject.Transform.Position.Y);
            }
            if (GameObject.Transform.Position.X > GameWorld.WorldSize.Width + spriteRenderer.Sprite.Width)
            {
                GameObject.Transform.Position = new Vector2(-spriteRenderer.Sprite.Width, GameObject.Transform.Position.Y);
            }
        }

        private void ScreenLimits()
        {
            if (GameObject.Transform.Position.Y < 0)
            {
                GameObject.Transform.Position = new Vector2(GameObject.Transform.Position.X, 0);
            }
            if (GameObject.Transform.Position.Y > GameWorld.WorldSize.Height- spriteRenderer.Sprite.Height)
            {
                GameObject.Transform.Position = new Vector2(GameObject.Transform.Position.X, GameWorld.WorldSize.Height - spriteRenderer.Sprite.Height);
            }
        }
    }
}
