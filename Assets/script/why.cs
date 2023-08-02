using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class why : MonoBehaviour
{
    public AudioSource w;
    public player p;
    public dedMenu dme;
    private bool play;

    void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.transform.parent = null;
        if (collision.gameObject.CompareTag("Player") && w != null)
        {
            w.Play();
            play = true;
        }
    }

    void Update()
    {
        if (!play)
        {
            return;
        }
        if (w.isPlaying)
        {
            return;
        }
        play = false;
        p.ded = true;
        dme.ToggleEndMenu();
    }

}
