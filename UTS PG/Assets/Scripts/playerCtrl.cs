using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    public float speed;
    public float leftBorder;
    public float rightBorder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float nextPos = transform.position.x + move;

        if (nextPos>rightBorder || nextPos < leftBorder)
        {
            move = 0;
        }

        transform.Translate(move, 0, 0);
    }
}
