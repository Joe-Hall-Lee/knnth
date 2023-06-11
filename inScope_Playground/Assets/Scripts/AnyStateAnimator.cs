using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnyStateAnimator : MonoBehaviour
{
    private Animator animator;

    private Dictionary<string, AnyStateAnimation> anyStateAnimations = new Dictionary<string, AnyStateAnimation>();

    public Animator Animator { get => animator; private set => animator = value; }

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animate();
    }
    

    public void TryPlayAnimation(string animationName)
    {
        bool startAnimation = true;

        if (anyStateAnimations[animationName].HigherPrio == null)
        {
            StartAnimation();
        }
        else
        {
            foreach (string animName in anyStateAnimations[animationName].HigherPrio)
            {
                if (anyStateAnimations[animationName].IsPlaying == true)
                {
                    startAnimation = false;
                    break;
                }
            }    
            if (startAnimation)
            {
                StartAnimation();
            }
        }


        void StartAnimation()
        {
            foreach (string anim in anyStateAnimations.Keys.ToList())
            {
                if (!anyStateAnimations[anim].Async || anyStateAnimations[anim].Async && anyStateAnimations
                    [anim].HigherPrio.Contains(animationName))
                {
                    anyStateAnimations[anim].IsPlaying = false;
                }
            }

            anyStateAnimations[animationName].IsPlaying = true;
        }
    }


    public void AddAnimations(params AnyStateAnimation[] animations)
    {
        for (int i = 0; i <animations.Length; i++)
        {
            this.anyStateAnimations.Add(animations[i].AnimationName, animations[i]);
        }
        // anyStateAnimations.Add(newAnimation.AnimationName, newAnimation);
    }


    public void OnAnimationDone(string animationName)
    {
        anyStateAnimations[animationName].IsPlaying = false;
    }


    public bool IsAnimationActive(string animName)
    {
        return anyStateAnimations[animName].IsPlaying;
    }


    private void Animate()
    {
        foreach(string key in anyStateAnimations.Keys)
        {
            Animator.SetBool(key, anyStateAnimations[key].IsPlaying);
        }
    }
}