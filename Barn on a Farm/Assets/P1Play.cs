using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingGame : MonoBehaviour
{

    int Switch = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        //Player 1
        if (Input.GetButtonDown("Q") && Switch == 0)
        {
            var pos = transform.position;
            pos.x += 45;
            transform.position = pos;
            pos.y += 20;
            transform.position = pos;
            Switch = 1;
        }

        else if (Input.GetButtonDown("Q") && Switch == 1)
        {
            var pos = transform.position;
            pos.x -= 45;
            transform.position = pos;
            pos.y -= 20;
            transform.position = pos;
            Switch = 0;
        }

    }
}
