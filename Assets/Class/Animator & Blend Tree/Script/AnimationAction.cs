using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;

   public void Kick()
    {
        animator.Play("Kick");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
