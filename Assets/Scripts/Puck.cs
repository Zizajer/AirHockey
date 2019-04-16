using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    BoxCollider2D boxCollider;
    Rigidbody2D rb;
    public SceneManager sceneManager;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "RedPlayerGoal")
        {
            ScoreManager.incrementRedPlayerScore();
            StartCoroutine(sceneManager.ResetRound());
        }
        else if(collision.tag == "BluePlayerGoal")
        {
            ScoreManager.incrementBluePlayerScore();
            StartCoroutine(sceneManager.ResetRound());
        }
    }
}
