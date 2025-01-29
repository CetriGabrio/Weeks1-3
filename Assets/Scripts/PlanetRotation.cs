using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    // Speed of the planet's rotation
    public float rotationSpeed = 1.0f;

    //Speed of the planet's movement
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Planet's Rotation on the Z-axis by the rotation speed
        transform.Rotate(0, 0, rotationSpeed);

        // Planet's Movement on the Y-axis by the movement speed
        transform.Translate(0, moveSpeed, 0);
    }
}

