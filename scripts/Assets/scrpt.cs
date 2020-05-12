using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject[] objects;

    private void Start()
    {
        Instantiate(objects[2], objects[2].transform.position, objects[2].transform.rotation);
    }

}
