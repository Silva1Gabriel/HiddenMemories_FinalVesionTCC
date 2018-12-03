using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCandlePuzzle : MonoBehaviour
{
    // Código do puzzle da vela responsável por controlar as variáveis de uma das 3 velas.
    public ManagerCandlePuzzle mcp;
    // Use this for initialization
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            //spawParticle
            mcp.chamaVela3.SetActive(true);
            mcp.somChama3.SetActive(true);
            mcp.chama3 = true;

            if (mcp.firstCandle == true && mcp.secondCandle == true)
            {

                mcp.thirdCandle = true;

            }
           
        }
       
      
    }
}
