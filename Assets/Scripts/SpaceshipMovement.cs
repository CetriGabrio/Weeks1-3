using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SpaceshipMovement : MonoBehaviour
{
    public float turnSpeed = 1.0f;
    public float moveSpeed = 0.01f;
    public float turnAmount;
    public float moveAmount;
    

    void Start()
    {

    }

    void Update()
    {
        turnAmount = Input.GetAxis("Horizontal") * turnSpeed;
        transform.Rotate(0, 0, -turnAmount);
        moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(0, moveAmount, 0);

        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0) screenPos.x = 0;
        if (screenPos.x > Screen.width) screenPos.x = Screen.width;
        if (screenPos.y < 0) screenPos.y = 0;
        if (screenPos.y > Screen.height) screenPos.y = Screen.height;

        transform.position = (Vector2) Camera.main.ScreenToWorldPoint(screenPos);

    }
}

