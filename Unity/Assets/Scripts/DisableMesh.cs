using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMesh : MonoBehaviour
{
    //Código não utilizado na demo onde a mesh ficava transparente quando o jogador estava dentro do trigger;(transparencia utilizando o alpha);
    public float alphaValue = 1f;
    public float alphaValuetogo = 1f;
    public Renderer meshRender;


    void Update()
    {
        alphaValue = Mathf.Lerp(alphaValue, alphaValuetogo, Time.deltaTime);
        meshRender.material.color = new Color(1, 1, 1, alphaValue);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player") && alphaValue > 0)
        {
            alphaValuetogo = 0;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && alphaValue > 0)
        {
            alphaValuetogo = 1;
        }
    }
}
    
    

