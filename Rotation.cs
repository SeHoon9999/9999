using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Rotation : MonoBehaviour
{

    [SerializeField] private SpriteRenderer characterRenderer;

    private Controller controller;


    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    void Start()
    {

        controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        Rotate(newAimDirection);
    }


    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }


}

