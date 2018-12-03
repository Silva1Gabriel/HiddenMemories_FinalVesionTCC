using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaTrancada : MonoBehaviour {
    //Toca o som ao interagir com uma porta que não pode ser aberta.
    public AudioSource portaTrancada;
     void OnTriggerStay(Collider other)
    {
      if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            portaTrancada.Play();
        }
    }
}
