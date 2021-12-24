using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingcircle : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        //If you want to change the "Gravity Scale", go to GameObject "Circle"
        //you can find it under "Rigidbody 2D"
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Press Space to make the circle Jump <= the lance is following the cirlce
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
            //If you want the circle to jump higher or lower, go to GameObject "Circle"
            //you can find it under "Flyingcircle (Script)" => "Velocity"
        } 
    } 
}