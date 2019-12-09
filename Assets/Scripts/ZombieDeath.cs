using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;
    public AudioSource JumpScareMusic;
    public AudioSource ambientMusic;



    void DamageZombie(int DamageAmount)
    {
        System.Diagnostics.Debug.WriteLine("damage zombie? ");
        EnemyHealth -= DamageAmount;
    }

   


    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("Z_Walk1_InPlace");
            TheEnemy.GetComponent<Animation>().Play("Z_FallingBack");
           JumpScareMusic.Stop();
            ambientMusic.Play();

        }
    }
}