using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    [Range(0, 1)]
    public float t;

    public AnimationCurve curve;

    public Vector2 start;
    public Vector3 end;

    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 scale = transform.localScale;
        //float x = Mathf.Lerp(0, 1, t);

        t += Time.deltaTime * speed; 

        if (t > 1)
        {
            t = 0; 
        }

        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    }
}
