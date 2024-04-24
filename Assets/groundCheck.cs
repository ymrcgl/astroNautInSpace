using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour


{
    private SoundManager soundManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("FeetPos"))
        {
            soundManagerScript.Land();
        }
    }
}
