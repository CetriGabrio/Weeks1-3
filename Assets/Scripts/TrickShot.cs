using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TrickShot : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public float speed = 10;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * speed * Time.deltaTime; //* curve.Evaluate(t);
            t += t * Time.deltaTime;
        }
    }
}

