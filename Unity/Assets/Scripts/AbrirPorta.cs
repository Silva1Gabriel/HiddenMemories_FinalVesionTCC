using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AbrirPorta : MonoBehaviour {
    public AudioSource somPorta;
    public Animation animPorta;
    public bool portaAberta = false;
     void OnTriggerStay(Collider other)
    {/* Este código detecta se o player está no trigger e verifica se a porta está aberta e se o player pressionou a tecla em questão, 
      caso a ação seja executada a animação da porta toca, juntamente com o som.*/
        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && portaAberta==false)
        {
            somPorta.Play();
            animPorta.Play();
            portaAberta = true;
        }
    }
    
}
