using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject obj;

    private void Start()
    {
        Invoke("Inst", 2f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            StartCoroutine(instObj());
        }
    }

    IEnumerator instObj () {
        while (true)
        {
            Instantiate(obj, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }

    void Inst()
    {
        Instantiate(obj, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
    }

}
