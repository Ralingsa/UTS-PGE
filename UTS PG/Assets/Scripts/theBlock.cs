using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class theBlock : MonoBehaviour
{
    public int point;
    int score;
    Text scoreUI;

    void showScore()
    {
        scoreUI.text = "SCORE: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreUI = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ball")
        {
            Destroy(gameObject);
        }
    }
}
