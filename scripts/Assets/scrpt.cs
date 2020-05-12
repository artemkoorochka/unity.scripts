using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject[] objects;

    private void Start()
    {
        Instantiate(objects[2], Vector3(20, 30, 40));
    }

}
