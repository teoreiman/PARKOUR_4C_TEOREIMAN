using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionArea : MonoBehaviour
{

    public GameObject interactionMessage;
    public mercancia mercancia;
    public MoneyManager moneyManager;

    // Start is called before the first frame update
    void Start()
    {
        interactionMessage.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mercancia)
            {
                Destroy(mercancia.gameObject);
                moneyManager.UpdateMoney(mercancia.cost);
                StopInteraction();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        mercancia = other.GetComponent<mercancia>();
        if (mercancia)
        {
            interactionMessage.SetActive(true);
        }
    }

    void StopInteraction()
    {
        interactionMessage.SetActive(false);
        mercancia = null;

    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }
}