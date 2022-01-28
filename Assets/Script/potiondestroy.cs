using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//fait par Lucas

public class potiondestroy : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
}


