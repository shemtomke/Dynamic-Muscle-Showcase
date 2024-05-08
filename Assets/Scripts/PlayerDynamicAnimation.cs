using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDynamicAnimation : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
}
