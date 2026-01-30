using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScript : MonoBehaviour
{
    public AudioSource ScarySound;
    public GameObject ThePlayer;
    public GameObject JumpCam;
   // public GameObject FlashImg;
    public GameObject Itself;
    public Animator animator;
    public bool Start = false; 
    public bool Stop = false;
    public GameObject monster;
    private void OnTriggerEnter(Collider other)
    {
        monster.GetComponent<Animator>().SetBool("bloo", true);

        ScarySound.Play();
        monster.GetComponent<Animator>().Play("attack3");
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
      //  FlashImg.SetActive(true);
        StartCoroutine(Thing());
    }

    private IEnumerator Thing()
    {
        yield return new WaitForSeconds(2f);    
        SceneManager.LoadScene(1);
    }

   

}

 
