using _09_00.Components;
using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_00
{
    static class GameManager
    {
        public static List<GameObject> UIElements { get; set; } = new List<GameObject>();

        private static List<GameObject> lives = new List<GameObject>();

        public static int LifeCount { get; set; }

        private static float xOffset;

        private static GameObject currentLife;

        private static Button restartButton;

        private static int score;

        private static Label scoreLabel;

        public static void Initialize(Button button, Label label)
        {
            restartButton = button;
            scoreLabel = label;
        }

        public static void AddLife()
        {
            currentLife = new GameObject();

            SpriteRenderer sr = new SpriteRenderer();

            sr.ScaleFactor = 0.5f;

            sr.SetSprite("player");

            currentLife.AddComponent(sr);

            UIElements.Add(currentLife);

            currentLife.Transform.Translate(new Vector2(sr.Sprite.Width * sr.ScaleFactor * LifeCount +xOffset,10));

            xOffset += 5;

            LifeCount++;

            lives.Add(currentLife);
        }

        public static void RemoveLife()
        {
            UIElements.Remove(currentLife);

            LifeCount--;

            if (LifeCount > 0)
            {
                currentLife = lives[LifeCount - 1];
            }
            else
            {
                //GameOver
                GameOver();
            }

           
        }

        public static void GameOver()
        {
            GameObject gameOver = new GameObject();
            SpriteRenderer sr = new SpriteRenderer();
            sr.SetSprite("GameOver");
            gameOver.AddComponent(sr);
            UIElements.Add(gameOver);
            restartButton.Show();
        }

        public static void Reset()
        {
            restartButton.Hide();
            UIElements.Clear();
            LifeCount = 0;
            xOffset = 0;
            score = 0;
            scoreLabel.Text = "Score: " + score;
        }

        public static void AddPoint()
        {
            score++;
            scoreLabel.Text = "Score: " + score;
        }

    }
}
