using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SpaceshipMovement : MonoBehaviour
{
    // Spaceship's steering speed
    public float turnSpeed = 1.0f;

    // Spaceship's movement speed
    public float moveSpeed = 0.01f;

    // Public variables that can be modified in the inspector
    public float turnAmount;
    public float moveAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Getting the spaceship to move horizontally using the keyboard input (A & D)
        turnAmount = Input.GetAxis("Horizontal") * turnSpeed;
        // Rotation on the Z-axis based on the steering speed
        transform.Rotate(0, 0, -turnAmount);

        // Getting the spaceship's to move vertically using the keyboard input (W & S)
        moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        // Moving the object on the Y-axis based on the movement speed
        transform.Translate(0, moveAmount, 0);

        // Getting the object's coordinates to set the boundaries of the screen
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        // Set of if statements to keep the Spaceship whithin the screen's horizontal and vertical boundaries (corresponding to camera view)
        if (screenPos.x < 0) screenPos.x = 0;
        if (screenPos.x > Screen.width) screenPos.x = Screen.width;
        if (screenPos.y < 0) screenPos.y = 0;
        if (screenPos.y > Screen.height) screenPos.y = Screen.height;

        // Updating the spaceship's position to ensure the collisions are respected
        // Also added vector 2 to ensure that spaceship's Z.axis is not affected 
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(screenPos);
    }
}

