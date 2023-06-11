using _09_00.Components;
using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    static class GameManager
    {
        public static List<GameObject> UIElements { get; set; } = new List<GameObject>();

        public static int LifeCount { get; set; }

        private static float xOffset;

        private static GameObject currentLife;


        public static void AddLife()
        {
            currentLife = new GameObject();

            SpriteRenderer sr = new SpriteRenderer();

            sr.ScaleFactor = 0.5f;

            sr.SetSprite("player");

            currentLife.AddComponent(sr);

            UIElements.Add(currentLife);

            currentLife.Transform.Translate(new Vector2(sr.Sprite.Width * sr.ScaleFactor * LifeCount + xOffset, 10));

            xOffset += 5;

            LifeCount++;
        }

        public static void RemoveLife()
        {

        }

    }
}
