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

        private Collider collider;

        private bool immortal = false;

        private float immortalDuration = 3;

        private float immortalTime;

        private float blinkCooldown = .2f;

        private float timeSinceLastBlink;

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
            collider = (Collider)GameObject.GetComponent("Collider");
            collider.CollisionHandler += Collision;
            animator = (Animator)GameObject.GetComponent("Animator");
            animator.AddAnimation(new Animation("PlayerFly", 10));
            animator.PlayAnimation("PlayerFly");
            Reset();
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
            Immortality();
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


            // Normalizes the vector to make sure that we don't move faster diagonally
            velocity = Vector2.Normalize(velocity);
        }

        /// <summary>
        /// Moves the player based on input
        /// </summary>
        private void Move()
        {
            // Moves the player
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
            if (GameObject.Transform.Position.Y > GameWorld.WorldSize.Height- spriteRenderer.Rectangle.Height)
            {
                GameObject.Transform.Position = new Vector2(GameObject.Transform.Position.X, GameWorld.WorldSize.Height - spriteRenderer.Rectangle.Height);
            }
        }

        private void Collision(Collider other)
        {
            if (other.GameObject.Tag == "Enemy" && !immortal)
            {
                immortal = true;
                GameManager.RemoveLife();

                if (GameManager.LifeCount <= 0)
                {
                    RemovePlayer();
                }
                else
                {
                    
                    Reset();
                }

             
            }
        }


        private void Reset()
        {
            GameObject.Transform.Position = new Vector2((GameWorld.WorldSize.Width / 2) - (spriteRenderer.Rectangle.Width / 2), (GameWorld.WorldSize.Height) - (spriteRenderer.Rectangle.Height));
        }


        private void RemovePlayer()
        {
            Explode();
            GameObject.Destroy();
        }


        private void Explode()
        {
            GameObject explosion = new GameObject();
            explosion.AddComponent(new SpriteRenderer());
            explosion.AddComponent(new Animator());
            explosion.AddComponent(new Explosion(GameObject.Transform.Position));

            GameWorld.Instantiate(explosion);
        }


        public void ApplyShield()
        {
            GameObject go = new GameObject();
            go.AddComponent(new Shield(GameObject.Transform, new Vector2(-35, -35)));
            go.AddComponent(new SpriteRenderer(3));
            go.AddComponent(new Collider());
            GameWorld.Instantiate(go);
        }


        private void Immortality()
        {
            if (immortal)
            {
                timeSinceLastBlink += MyTime.DeltaTime;

                if (timeSinceLastBlink >= blinkCooldown)
                {
                    spriteRenderer.IsEnabled = !spriteRenderer.IsEnabled;
                    timeSinceLastBlink = 0;
                }

                immortalTime += MyTime.DeltaTime;

                if (immortalTime >= immortalDuration)
                {
                    immortal = false;
                    spriteRenderer.IsEnabled = true;
                    immortalTime = 0;
                    timeSinceLastBlink = 0;
                }
            }
        }
    }
}