using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class SupplyCrate : Component
    {

        private Vector2 spawnPosition;

        private Collider collider;


        public SupplyCrate(Vector2 position)
        {
            this.spawnPosition = position;
        }

        public override void Awake()
        {
            SpriteRenderer spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");

            spriteRenderer.SortOrder = 0;
            spriteRenderer.ScaleFactor = 0.5f;
            spriteRenderer.SetSprite("supply-crate");
            GameObject.Transform.Position = spawnPosition;
            GameObject.Transform.Position += new Vector2(20, 15);
            collider = (Collider)GameObject.GetComponent("Collider");
            collider.CollisionHandler += Collision;
           
        }

        private void Collision(Collider other)
        {
            if (other.GameObject.Tag =="Player")
            {
                GameObject.Destroy();
            }
        }
    }
}
