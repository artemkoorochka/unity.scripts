using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject obj;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            StartCoroutine(instObj());
        }
    }

    IEnumerator instObj () {
        yield return new WaitForSeconds(1.5f);
        Instantiate(obj, obj.transform.position, Quaternion.identity);
    }



}
