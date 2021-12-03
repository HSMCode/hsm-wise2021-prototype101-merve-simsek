using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}