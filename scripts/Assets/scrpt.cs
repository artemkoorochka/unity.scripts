using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    private void Awake()
    {
        print("Awake work before Start");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Hi");
    }

    // Update is called once per frame
    void Update()
    {
        print("Game Upadate");
    }
}
