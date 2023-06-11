using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyStateAnimation
{
    public string AnimationName { get; set; }

    public bool IsPlaying { get; set; }

    public string[] HigherPrio { get; set; }

    public bool Async { get; set; }

    public AnyStateAnimation(string animationName, bool async, params string[] higherPrio)
    {
        this.AnimationName = animationName;
        this.HigherPrio = higherPrio;
        this.Async = async;
    }
}