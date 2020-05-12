using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    [SerializeField]
    private float score = 24.24f;

    private void Start()
    {
        showScore();
    }



    void showScore()
    {
        print("Score: " + score);
    }
}
