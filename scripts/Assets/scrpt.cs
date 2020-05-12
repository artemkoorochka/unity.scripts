using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{

    private Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }
}
