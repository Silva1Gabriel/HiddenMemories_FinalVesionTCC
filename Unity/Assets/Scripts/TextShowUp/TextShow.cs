using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShow : MonoBehaviour
{// Verifica se o player entrou no collider e revela o texto na tela.
    public GameObject text;
    public Animation textFade;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            textFade.Play();
        }
    }
}
