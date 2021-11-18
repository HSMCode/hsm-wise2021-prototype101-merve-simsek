using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    public GameObject TextBox;
    public int TheNumber;

    public void RandomGenerate () 
    {
        TheNumber = Random.Range (1, 20);
        TextBox.GetComponent<Text> ().text = "" + TheNumber;
        
        if (TheNumber == 3)
        {
            Debug.Log("Win");
        }
        if (TheNumber == 5)
        {
            Debug.Log("Win");
        }
        if (TheNumber == 17)
        {
            Debug.Log("Win");
        }
    }

}
