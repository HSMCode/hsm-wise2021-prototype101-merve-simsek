using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    //Speed of the scrolling Background
    public float speed = 4f; 
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }

    void Update()
    {
        //infinite Scrolling Background 
        //"-21.49" is the x position when the first Background picture end
        transform. Translate( translation: Vector3. left*speed*Time.deltaTime);
        if (transform.position.x < -21.49f)
        {
            transform.position = StartPosition;
        }
    }
}
