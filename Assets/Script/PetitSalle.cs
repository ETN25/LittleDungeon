using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne
public class PetitSalle : MonoBehaviour
{
    public int Mobs;
    public GameObject Grille1, Grille2, MobsSpawn;
    bool Activé;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Mobs == 0)
        {
            Grille1.GetComponent<Animator>().SetTrigger("Ouverture");
            Grille2.GetComponent<Animator>().SetTrigger("Ouverture");
        }
    }

    public void MortEnnemy()
    {
        Mobs --;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") && Activé == false)
        {
            Grille1.GetComponent<Animator>().SetTrigger("Fermeture");
            Grille2.GetComponent<Animator>().SetTrigger("Fermeture");
            Activé = true;
            MobsSpawn.SetActive(true);
        }
    }
}
