﻿using UnityEngine.InputSystem.XR;
using UnityEngine;

public class CharacterAnimator : Animtation
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold);
    }

}