using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormCall : MonoBehaviour
{
    // código não utilizado mais, porém funcioanava da seguinte maneira: Ao passar pelo trigger a varivael bool passava a ser verdadeira e os eventos de ativação da partiula e do som eram acionados.
    public AudioSource Thunder;
    public AudioSource ChuvaSound;
    public GameObject ChuvaParticle;
    public bool triggerAtivo = false;
    public Animation chuvaAnim;
    public GameObject Triggerchuva;

    void Update()
    {
        if (triggerAtivo == true)
        {
            AtivarThunder();
            Invoke("AtivarSomChuva", 7);
            Invoke("AtivarParticulas", 9);
            triggerAtivo = false;
            Triggerchuva.SetActive(false);

        }   
    }
   
    public void AtivarThunder()
    {
        Thunder.Play();
    }
    public void AtivarSomChuva()
    {
        chuvaAnim.Play();
        ChuvaSound.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            triggerAtivo = true;
        }
    }
    public void AtivarParticulas()
    {
        ChuvaParticle.SetActive(true);
    }
}
