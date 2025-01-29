using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPulse : MonoBehaviour
{
    // Setting the animation curve as public
    public AnimationCurve curve;

    // Defining a variable for the animation and setting the range from 0 to 1
    [Range(0f,1)]
    public float t;

    // Speed of the animation
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Animation starts at 0
        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Speed of the curve following real time and then multiply it by the speed
        t += Time.deltaTime * speed;

        // Resetting the animation when it reaches the limit
        if(t > 1)
        {
            t = 0f;
        }

        // Update and scale the object based on the current value of the animation curve
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
