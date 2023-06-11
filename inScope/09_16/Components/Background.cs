using _09_02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class Background : Component
    {
        private SpriteRenderer spriteRenderer;

        private Vector2 startPosition;

        private Image sprite;

        private float speed;

        public Background(string spriteName, Vector2 position, float speed)
        {
            this.startPosition = position;
            sprite = Image.FromFile($@"Sprites/{spriteName}.png");
            this.speed = speed;
        }

        public override void Awake()
        {
            this.spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            this.spriteRenderer.Sprite = sprite;
            this.GameObject.Transform.Position = startPosition;
        }

        public override void Update()
        {
            Move();
        }

        private void Move()
        {
            GameObject.Transform.Translate(new Vector2(0, 1) * speed * MyTime.DeltaTime);
            
            if (GameObject.Transform.Position.Y > GameWorld.WorldSize.Height)
            {
                Reset();
            }
        }

        private void Reset()
        {
            GameObject.Transform.Position = new Vector2(0, -spriteRenderer.Sprite.Height);
        }
    }
}
