using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1.0f;
    [SerializeField] float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed;
        transform.Rotate(0, 0, -turnAmount);
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(0, moveAmount, 0);
    }
}
