using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    
    public GameObject obj;
    private Light myLight;
    private int numEnimies = 10;

    private void Start()
    {
        // При старте присваиваем нашей переменной обект с юнити Directional Light
        myLight = GetComponent<Light>();

        // cicle
        for (int i = 0; i < numEnimies; i++)
        {
            Debug.Log("Create " + i + " enimis");
        }
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

        // RGB color
        if(Input.GetKeyUp(KeyCode.R))
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        if(Input.GetKeyUp(KeyCode.G))
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
        if(Input.GetKeyUp(KeyCode.B))
        {
            obj.GetComponent<Renderer>().material.color = Color.blue;
        }

    }
}
