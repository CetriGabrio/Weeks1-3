using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Asteroid's movement speed
    [SerializeField] float speed = 0.2f;

    // Asteroid's rotation speed
    [SerializeField] float rotationSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Getting the asteroi'd position and moving it on the X-axis by the movement speed
        Vector2 pos = transform.position;
        pos.x += speed;

        // Getting the object's coordinates to set the boundaries of the screen
        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        // Checking if the object is inside the boundaries of the camera view:
        // If it is, keep going
        // If it is not, set the speed to negative value to obtain movement in the opposite direction
        if(squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        //Updating the asteroid's position
        transform.position = pos;

        //Asteroid's rotation on the Z-axis by the rotation speed
        transform.Rotate(0, 0, -rotationSpeed);
    }
}
