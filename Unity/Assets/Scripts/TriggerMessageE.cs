using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessageE : MonoBehaviour {
    // Código responsável pelo feedback de mensagem ao interagir pressionando E dentro do trigger.
    public GameObject message;
    
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            message.SetActive(true);
        }
       
    }
    public void OnTriggerExit(Collider other)
    {
        message.SetActive(false);
    }
}
