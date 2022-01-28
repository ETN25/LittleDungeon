using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySound : MonoBehaviour
{
    public AudioSource sound;
    public float timercount;
    private float timer;
    void Start()
    {
        timercount = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timercount -= Time.deltaTime;
        if (timer <= 0)
        {
            sound.Play();
            //animation
            timer = timercount;
        }
    }
    public void Sound()
    {





    }
}
