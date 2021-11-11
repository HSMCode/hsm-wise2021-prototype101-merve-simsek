using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Hi");
        Debug.LogError ("Error");
        Debug.LogWarning ("Warning");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
