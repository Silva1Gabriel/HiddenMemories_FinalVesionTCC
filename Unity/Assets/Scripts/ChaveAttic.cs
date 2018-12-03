using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveAttic : MonoBehaviour {
    public GameObject mensagemChaveAttic;
    public GameObject chaveAtticObject;
    public AudioSource item;
    public GameObject TriggerPorão;
    public GameObject messageTriggerPorao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            //Verificada as condições de o player se encontrar n trigger e pressionar a tecla, o som de interação toca, a imagem aparece, o objeto sai de cena, e é liberada mais uma área de exploração.
            item.Play();
            chaveAtticObject.SetActive(false);
            mensagemChaveAttic.SetActive(true);
            TriggerPorão.SetActive(true);
            messageTriggerPorao.SetActive(false);
        }
    }

}
