using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void OnCollisionEnter(Collision coll)
        {
             if (coll.gameObject.tag == "Schwert")
             {
                 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                 Debug.Log("Game Over Reload");
             }
        }
}
