using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerHeath playerHeath;
    public float restartDelay = 5;

    Animator anim;
    float restartTime;

	// Use this for initialization
	void Awake () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if(playerHeath.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

            restartTime += Time.deltaTime;

            if(restartTime >= restartDelay)
            {
                Application.LoadLevel(0);
            }
        }

	}
}
