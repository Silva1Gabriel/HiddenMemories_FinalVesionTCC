using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    // Não destroi o objeto ao carregar a cena;
    public GameObject Dont;
    private void Awake()
    {
        DontDestroyOnLoad(Dont);
    }
}
