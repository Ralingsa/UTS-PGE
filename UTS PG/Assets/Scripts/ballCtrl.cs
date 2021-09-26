using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballCtrl : MonoBehaviour
{
    private bool isStart;
    public int force;
    Rigidbody2D rigid;

    public Animation transition;

    public Text clickSpace;
    int score;
    Text scoreUI;
    GameObject panelOver;

    void showScore()
    {
        scoreUI.text = "SCORE: " + score;
    }

    void resetBall()
    {
        transform.localPosition = new Vector2(0, 0);
        rigid.velocity = new Vector2(0, 0);
    }

    void startBall()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !isStart)
        {
            rigid = GetComponent<Rigidbody2D>();
            Vector2 direction = new Vector2(0, -2).normalized;
            rigid.AddForce(direction * force);
            isStart = true;
            clickSpace.gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isStart = false;
        score = 0;
        scoreUI = GameObject.Find("score").GetComponent<Text>();
        panelOver = GameObject.Find("over");
        panelOver.SetActive(false);
        clickSpace.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        startBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "end")
        {
            resetBall();
            isStart = false;
            clickSpace.gameObject.SetActive(true);
            startBall();
        }
        if (collision.gameObject.name == "player")
        {
            float sudut = (transform.position.x - collision.transform.position.x) * 5f;
            Vector2 direction = new Vector2(sudut, rigid.velocity.y).normalized;
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(direction * force * 2);
        }
        if (collision.gameObject.CompareTag("5"))
        {
            score +=5;
            showScore();
            if (score == 100)
            {
                panelOver.SetActive(true);
            }
        }
        if (collision.gameObject.CompareTag("10"))
        {
            score += 10;
            showScore();
            if (score == 100)
            {
                panelOver.SetActive(true);
            }
        }
        if (collision.gameObject.CompareTag("20"))
        {
            score += 20;
            showScore();
            if (score == 100)
            {
                panelOver.SetActive(true);
            }
        }
    }
}
