using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour  
{
    //fait par Thomas J le bg de la prog hackeur de la nasa par ces bugs 

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    [SerializeField] private InputAction menu;
    // Start is called before the first frame update

    private void OnEnable()
    {
        menu.Enable();

    }
    private void OnDisable()
    {
        menu.Disable();
    }


    void Start()
    {
        menu.performed += _ =>
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                pausefonc();
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                pausefonc();
            }
        }
        */
    }
    void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Plus Pause");
    }
    void pausefonc ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("Pause");
    }
}
