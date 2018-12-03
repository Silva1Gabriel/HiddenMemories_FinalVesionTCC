using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCandlePuzzle : MonoBehaviour
{// Código do puzzle da vela responsável por controlar as variáveis de uma das 3 velas.
    public ManagerCandlePuzzle mcp;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            mcp.chama1 = true;
            mcp.chamaVela1.SetActive(true);
            mcp.somChama1.SetActive(true);

            if (mcp.secondCandle == false && mcp.thirdCandle == false)
            {
                mcp.firstCandle = true;
            }
         
        }


    }



}