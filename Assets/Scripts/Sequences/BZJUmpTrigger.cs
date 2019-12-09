using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJUmpTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheZombie;
    public GameObject TheDoor;
    public AudioSource ambientSound;
    //private Animation anim;



    void OnTriggerEnter()
    {

        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("JumpDoorAnim");
        DoorBang.Play();
        TheZombie.SetActive(true);
        //anim = GetComponent<Animation>();
        //anim = true;
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        ambientSound.Stop();
        DoorJumpMusic.Play();
    }



}
