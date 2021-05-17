using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip crowd;
    public AudioClip charge;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(crowd);
        audio.PlayOneShot(charge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
