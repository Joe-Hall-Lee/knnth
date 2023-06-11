using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class BackgroundElement : Background
    {
        private static Random rnd = new Random();

        public BackgroundElement(string spriteName) : base(spriteName, Vector2.Zero, 0, null)
        {
        }

        public override void Start()
        {
            Reset();
        }

        public override void Reset()
        {
            speed = rnd.Next(30, 50);
            float x = rnd.Next(0, GameWorld.WorldSize.Width - spriteRenderer.Sprite.Width);
            GameObject.Transform.Position = new Vector2(x, -spriteRenderer.Sprite.Height);
        }
    }
}
