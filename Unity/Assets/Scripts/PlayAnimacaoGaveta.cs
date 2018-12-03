using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimacaoGaveta : MonoBehaviour {
    // Código responsáve por rodar a animação e som da gaveta ao receber os devidos inputs do jogador.
    public Animator gaveta;
    public bool gavetaAberta = false;
    public AudioSource somGaveta;
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && gavetaAberta==false)
        {
            gavetaAberta = true;
            somGaveta.Play();
            gaveta.SetBool("Open", true);
          
        }
    }
}
