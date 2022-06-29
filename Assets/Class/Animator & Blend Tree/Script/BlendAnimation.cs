using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
