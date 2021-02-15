﻿using UnityEngine;
 
public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
 
    void Awake ()
    {
        //Cari game object dengan tag player
        player = GameObject.FindGameObjectWithTag("Player").transform;
 
        //Mendapatkan Reference component
        nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }
 
 
    void Update ()
    {
        nav.SetDestination(player.position);
    }
}