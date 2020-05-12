using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject obj;
    public float range = 5f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xpos = h * range;

        obj.transform.position = new Vector3(xpos, 0, 0);
    }
}
