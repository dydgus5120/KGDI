using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    Transform player;

    NavMeshAgent nav;

    PlayerHeath playerHeath;
    EnemyHealth enemyHealth;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHeath = player.GetComponent<PlayerHeath>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (enemyHealth.currentHealth > 0 && playerHeath.currentHealth > 0)
            nav.SetDestination(player.position);

        else
            nav.enabled = false;
	}
}
