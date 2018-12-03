using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAdquirido : MonoBehaviour {

    public bool itemPego = false;
    public GameObject backGround;
    public GameObject itemMacaneta;
    public GameObject triggerMensagem;
    public GameObject mensagemItem;
    public AudioSource itemSound;
     void OnTriggerStay(Collider other)
    {// Se o player estiver no trigger ativa a mensagem;
        triggerMensagem.SetActive(true);
        backGround.SetActive(true);

        if (other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E) && itemPego==false)
        {// se o player estiver no trigger e realizar a ação o item é pego, o som é tocado e as mensagens somem.
            itemSound.Play();
            itemPego = true;
            itemMacaneta.SetActive(false);
            mensagemItem.SetActive(true);
            backGround.SetActive(false);

        }
        if(itemPego==true)
        {
            //evita que a mensagem fique reaparecendo mesmo que o item tenha sido pego;
            triggerMensagem.SetActive(false);
        }
      
    }

     void OnTriggerExit(Collider other)
    {
        // Mensagem desabilitada se o player nao estier no trigger.
        triggerMensagem.SetActive(false);
    }
}
