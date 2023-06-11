using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// The Enemy's awake method
        /// </summary>
        public override void Awake()
        {
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("enemy_01");
            spriteRenderer.ScaleFactor = 0.7f;
        }
    }
}