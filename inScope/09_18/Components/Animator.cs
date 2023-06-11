using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    class Animator : Component
    {
        private SpriteRenderer spriteRenderer;

        private Dictionary<string, Animation> animations = new Dictionary<string, Animation>();

        private Animation currentAnimation;

        private float timeElapsed;

        private int currentIndex;

        public override void Awake()
        {
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
        }

        public override void Update()
        {
            if (currentAnimation != null)
            {
                timeElapsed += MyTime.DeltaTime;

                currentIndex = (int)(timeElapsed * currentAnimation.Speed);

                if (currentIndex > currentAnimation.Sprites.Length-1)
                {
                    timeElapsed = 0;
                    currentIndex = 0;
                }

                spriteRenderer.Sprite = currentAnimation.Sprites[currentIndex];
            }
        }

        public void AddAnimation(Animation animation)
        {
            animations.Add(animation.Name, animation);
        }

        public void PlayAnimation(string animationName)
        {
            currentAnimation = animations[animationName];
        }

        public override string ToString()
        {
            return "Animator";
        }
    }
}