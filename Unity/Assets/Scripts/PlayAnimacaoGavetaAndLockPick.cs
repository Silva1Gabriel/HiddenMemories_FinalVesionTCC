using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimacaoGavetaAndLockPick : MonoBehaviour {
    public Animator gaveta;
    public bool gavetaAberta = false;
    public AudioSource somGaveta;
    public lockPick LP;
    public void OnTriggerStay(Collider other)
    {//Aciona a animaçao e som da gaveta e o som e surgimento do lockpick;
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && gavetaAberta == false)
        {
            LP.lockPickObject.SetActive(true);
            gavetaAberta = true;
            somGaveta.Play();
            gaveta.SetBool("Open", true);

        }
    }
}
