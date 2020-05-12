using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject obj;
    private Light myLight;

    private void Start()
    {
        // При старте присваиваем нашей переменной обект с юнити Directional Light
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }

        if(Input.GetKeyUp(KeyCode.A))
        {
            obj.SetActive(false);
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            obj.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Delete))
        {
            Destroy(obj);
        }
    }
}
