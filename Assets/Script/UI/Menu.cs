using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
    //fait par Thomas J
{
    public AudioSource sound;
    public AudioSource sound2;
    public float timercount;
    
    void Start()
    {
        
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }
    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        sound2.Play();

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        sound2.Play();
    }
    public void Retry()
    {
        Debug.Log("re");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        sound2.Play();
        sound2.Pause();
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
        sound2.Play();
    }
}
    
