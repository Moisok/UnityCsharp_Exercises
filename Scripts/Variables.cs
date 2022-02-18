using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int score = 0;

    public bool win = false;

     void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        score++;

        if (score > 10){
            win = true;
            Debug.Log(win);
        }
        else{
            win = false;
            Debug.Log(win);
        }
    }
}
