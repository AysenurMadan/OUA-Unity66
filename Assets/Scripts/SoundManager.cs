using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip deathByFall;
    [SerializeField] AudioClip pickingSound;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Jump() {
        audioSource.PlayOneShot(jump);
    }

    public void Jump()
    {
        audioSource.PlayOneShot(deathByFall);
    }

    public void Jump()
    {
        audioSource.PlayOneShot(pickingSound);
    }


}
