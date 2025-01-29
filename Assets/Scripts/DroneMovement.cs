using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{

    // Setting the animation curve as public
    public AnimationCurve curve;

    // Defining a variable for the animation and setting the range from 0 to 1
    [Range(0, 1)]
    public float t;

    // Speed of the animation
    public float speed = 0.1f;

    //Setting the variables for the start and end position of the Lerp function
    public Vector2 start;
    public Vector3 end;

    // Start is called before the first frame update
    void Start()
    {
        // Animation starts at 0
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Speed of the curve following real time and then multiply it by the speed
        t += Time.deltaTime * speed;

        // Resetting the animation when it reaches the limit
        if (t > 1)
        {
            t = 0; 
        }

        //Movement of the drone from start to end point based on the current value of the animation curve
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    }
}
