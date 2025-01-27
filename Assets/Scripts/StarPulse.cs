using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPulse : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0f,1)]
    public float t;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;

        if(t > 1)
        {
            t = 0f;
        }
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
