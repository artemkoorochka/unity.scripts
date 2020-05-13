using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{

    public GameObject obj;
    private GameObject inst_obj;

    [SerializeField]
    private float speed = 100f;

    private void Start()
    {
        inst_obj = Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    private void Update()
    {
        float zPositin = Input.GetAxis("Vertical");

        inst_obj.transform.Translate(Vector3.forward * speed * zPositin * Time.deltaTime);
    }
}
