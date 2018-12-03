using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pos : MonoBehaviour {
    //Responsável por salvar a posiçao do player ao entrar em contato com os checkpoints;
    private GameMaster gm;
	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
