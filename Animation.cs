using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animtation : MonoBehaviour
{
    protected Animator animator;
    protected Controller controller;
    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<Controller>();
    }
}
