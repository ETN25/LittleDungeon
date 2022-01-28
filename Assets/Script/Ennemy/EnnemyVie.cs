using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne

public class EnnemyVie : MonoBehaviour
{
    public float Vie;
    public GameObject Salle;
    public bool mort = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vie == 0)
        {
            if (!mort)
            {
                Salle.GetComponent<PetitSalle>().MortEnnemy();
                mort = true;
            }

            Destroy(gameObject, 0.25f) ;
 
        }
    }

    public void Degats()
    {
        Vie--;
        Debug.Log("touché");
    }
}
