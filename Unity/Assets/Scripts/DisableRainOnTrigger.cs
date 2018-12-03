using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRainOnTrigger : MonoBehaviour {
    // Controle da chuva para poupar processamento ao entrar em partes do cenário onde não tenha como notar as particulas.
    public GameObject chuvaMae;
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            chuvaMae.SetActive(false);
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            chuvaMae.SetActive(true);
        }
    }
}
