using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    public delegate void AnimationDoneDelege(string name);
    class Animator : Component
    {
        public AnimationDoneDelege AnimationDoneEvent { get; set; }

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
                    OnAnimationDone(currentAnimation.Name);
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

            if (spriteRenderer != null)
            {
                spriteRenderer.Sprite = currentAnimation.Sprites[0];
            }
        }

        public override string ToString()
        {
            return "Animator";
        }

        public void OnAnimationDone(string name)
        {
            if (AnimationDoneEvent != null)
            {
                AnimationDoneEvent.Invoke(name);
            }
           
        }
    }
}
