using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//fait pas lucas


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public AudioSource sound;
   

    public HealthBar1 healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        sound.Play();

    }

    void Update()
    {
        if (currentHealth <= 1)
        {
            SceneManager.LoadScene(0);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ennemy"))
        {
            currentHealth = currentHealth - 10 ;
            healthBar.SetHealth(currentHealth);
            StartCoroutine(bitch());

        }

    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.CompareTag("health"))
        {
            currentHealth = currentHealth + 20;
            healthBar.SetHealth(currentHealth);
            Destroy(other, 0.1f);


        }
        if (other.transform.CompareTag("health1"))
        {
            currentHealth = currentHealth + 50;
            healthBar.SetHealth(currentHealth);
            Destroy(other, 0.1f);

        }

        if (other.transform.CompareTag("Projectile"))
        {
            currentHealth = currentHealth - 5;
            healthBar.SetHealth(currentHealth);
            StartCoroutine(bitch());
            Destroy(other, 0.1f);

        }
    }
    IEnumerator bitch()
    {
        yield return new WaitForSeconds(1);
    }
    
    

    

}
