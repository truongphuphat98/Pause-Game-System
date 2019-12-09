using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame01 : MonoBehaviour
{
    [SerializeField] bool IsPaused = false;
    public KeyCode pauseKey;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GamePause();
    }
    void GamePause()
    {
        if(Input.GetKeyDown(pauseKey))
        {
            IsPaused = !IsPaused;

            if(IsPaused)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
    }
}
