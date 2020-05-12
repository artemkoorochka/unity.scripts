using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject[] objects;
    private GameObject instObject;

    private void Start()
    {
        int rand = Random.Range(0, objects.Length - 1);
        instObject = Instantiate(objects[rand], objects[rand].transform.position, Quaternion.identity) as GameObject;
        instObject.transform.localScale = new Vector3(0.24f, 0.24f, 0.24f);
    }

}
