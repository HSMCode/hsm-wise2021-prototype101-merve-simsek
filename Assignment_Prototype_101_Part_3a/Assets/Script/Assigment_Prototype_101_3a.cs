using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment_Prototype_101_3a : MonoBehaviour
{
    public int myFirstInteger;
    public int mySecondInteger;
    public int myThirdInteger;
    public int myFourthInteger;
    public int myFifthInteger;
    
    public string MyFirstText = "Mein erster Text";



    // Start is called before the first frame update
    void Start()
    {
        myFirstInteger = 10;
        mySecondInteger = 20;
        myThirdInteger = 30;
        
        myFourthInteger = myFirstInteger + mySecondInteger + myThirdInteger;

        myFifthInteger = myFourthInteger / 3;

        Debug.Log(myFifthInteger);

        Debug.Log("Das ist String hier, der da: " + MyFirstText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
