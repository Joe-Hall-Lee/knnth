using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    enum SupplyType {LIFE, SHIELD }
    class SupplyCrate : Component
    {

        private Vector2 spawnPosition;

        private Collider collider;

        private SupplyType supplyType;

        private static Random rnd = new Random();

        public SupplyCrate(Vector2 position)
        {
            this.spawnPosition = position;
            supplyType =(SupplyType)rnd.Next(0, 2);
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
             
                switch (supplyType)
                {
                    case SupplyType.LIFE:
                        GameManager.AddLife();
                        break;
                    case SupplyType.SHIELD:
                        (other.GameObject.GetComponent("Player") as Player).ApplyShield();
                        break;
                }
                GameObject.Destroy();
            }
        }
    }
}
