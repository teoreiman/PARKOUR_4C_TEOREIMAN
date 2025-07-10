using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColisores : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}