using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip landing;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Jump()
    {
        audioSource.PlayOneShot(jump);
    }
    public void Land()
    {
        audioSource.PlayOneShot(landing);
    }
}
