using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    AudioSource audioSource;
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip picking;
    [SerializeField] AudioClip deathByFall;

    // Start is called before the first frame update
    void Start()
    {
             audioSource = GetComponent<AudioSource>();
      
    }

    public void Jump()
    {
        audioSource.PlayOneShot(jump);
    }
    public void Picking()
    {
        audioSource.PlayOneShot(picking);
    }
    
    public void DeathByFall()
    {
        audioSource.PlayOneShot(deathByFall);
    }



}
}
