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

        private Animator animator;

        /// <summary>
        /// The Enemy's movement speed
        /// </summary>
        private float speed;

        /// <summary>
        /// Generates random numbers
        /// </summary>
        private static Random random = new Random();

        private Collider collider;

        /// <summary>
        /// The Enemy's awake method
        /// </summary>
        public override void Awake()
        {
            GameObject.Tag = "Enemy";
            speed = 100;
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            collider = (Collider)GameObject.GetComponent("Collider");
            collider.CollisionHandler += Collision;
            spriteRenderer.SetSprite("enemy_01");
            spriteRenderer.ScaleFactor = 0.7f;
            animator = (Animator)GameObject.GetComponent("Animator");
            animator.AddAnimation(new Animation("EnemyFly", 10));
            animator.PlayAnimation("EnemyFly");
            Reset();
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

        /// <summary>
        /// This method is executed if the enemy collides with another object.
        /// </summary>
        /// <param name="other"></param>
        private void Collision(Collider other)
        {
            if (other.GameObject.Tag == "Laser")
            {
                other.GameObject.Destroy();
                Explode();
                Reset();
            }
        }

        private void Explode()
        {
            GameObject explosion = new GameObject();
            explosion.AddComponent(new SpriteRenderer());
            explosion.AddComponent(new Animator());
            explosion.AddComponent(new Explosion(GameObject.Transform.Position));
            GameManager.AddPoint();
            GameWorld.Instantiate(explosion);
        }
    }
}