using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColisores : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hay contacto");
        Destroy(collision.gameObject);
    }

    void Update()
    {

    }
}