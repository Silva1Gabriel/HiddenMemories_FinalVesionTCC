using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armarioPortas : MonoBehaviour
{

    public Animation anim1;
    public bool aberto = false;


    public GameObject mensagemArmario;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            anim1.Play();

        }
        if (aberto == true)
        {
            mensagemArmario.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        mensagemArmario.SetActive(false);
    }
}

//Este código tem funcionamento semelhante ao do funcionamento das portas, sendo que a unica diferença são os objetos em questão.