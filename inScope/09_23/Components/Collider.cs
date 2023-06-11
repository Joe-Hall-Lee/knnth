using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    /// <summary>
    /// Delegate for our collision events
    /// </summary>
    /// <param name="other"></param>
    public delegate void CollisionEventHandler(Collider other);

    public class Collider : Component
    {
        /// <summary>
        /// The GameObject's spriterenderer
        /// We need a reference to it so that the collider has a bounding box
        /// </summary>
        private SpriteRenderer spriteRenderer;

        /// <summary>
        /// A Collision Handler event, that is invoked whenever a collision happens
        /// </summary>
        public event CollisionEventHandler CollisionHandler;

        /// <summary>
        /// This list contains all colliders in the game
        /// </summary>
        private static List<Collider> colliders = new List<Collider>();

        private List<Collider> otherCollideres = new List<Collider>();

        public override void Awake()
        {
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");

            colliders.Add(this);
        }

        public override void Update()
        {
            for (int i = 0; i < colliders.Count; i++)
            {
                //Check if these two collides
                OnCollision(colliders[i]);
            }
        }

        /// <summary>
        /// Checks if a collision has happend
        /// </summary>
        /// <param name="other"></param>
        private void OnCollision(Collider other)
        {
            if (other != this)
            {
                RectangleF intersection = RectangleF.Intersect(spriteRenderer.Rectangle, other.spriteRenderer.Rectangle);

                if (!otherCollideres.Contains(other))
                {
                    if ((intersection.Width > 0 || intersection.Height > 0) && CollisionHandler != null)
                    {
                        otherCollideres.Add(other);
                        CollisionHandler.Invoke(other);
                    }
                }
                else
                {
                    if ((intersection.Width <= 0 || intersection.Height <= 0) && CollisionHandler != null)
                    {
                        otherCollideres.Remove(other);
                    }
                }

        
            }
        }

        /// <summary>
        /// Makes sure that we clean up when the collider is destroyed
        /// </summary>
        public override void Destory()
        {
            colliders.Remove(this);
        }

        public override string ToString()
        {
            return "Collider";
        }


    }
}
