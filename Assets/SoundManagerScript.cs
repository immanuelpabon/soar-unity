using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip enemyFireSound, playerHitSound, winSound, loseSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        enemyFireSound = Resources.Load<AudioClip>("enemyFire");
        playerHitSound = Resources.Load<AudioClip>("playerhit");
        winSound = Resources.Load<AudioClip>("win");
        loseSound = Resources.Load<AudioClip>("lose");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            case "enemyFire":
                audioSrc.PlayOneShot(enemyFireSound);
                break;
            case "playerHit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "win":
                audioSrc.PlayOneShot(winSound);
                break;
            case "lose":
                audioSrc.PlayOneShot(loseSound);
                break;
        }
    }
}
