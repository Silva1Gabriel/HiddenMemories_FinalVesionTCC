using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleDoll : MonoBehaviour
{
    // Código responsável pelo controle do Ragdoll do personagem.
    public Rigidbody[] myRigidbodys;

    public MoveCharacterTuca MCT;
    public ControleDoll cD;
    public Animator playerAn;
    public GameObject canvasMorte;

    void Start()
    {
        myRigidbodys = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rdb in myRigidbodys)
        {
            //ativa todos os kinematics do rigidbody presentes;
            rdb.isKinematic = true;
        }
    }
    public void Update()
    {
        
           
        
    }
    public void Morte()
    {
        foreach (Rigidbody rdb in myRigidbodys)
        {
            //Desativa os comandos, animação, e o ragdoll do player, além disso o level será reiniciado após o tempo determinado.
            MCT.enabled = false;
            canvasMorte.SetActive(true);
            playerAn.enabled = false;
            rdb.isKinematic = false;
            Invoke("RestartScene", 8);
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("Basement");
    }

}
