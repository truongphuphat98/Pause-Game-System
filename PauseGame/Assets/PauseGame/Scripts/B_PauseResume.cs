using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_PauseResume : MonoBehaviour
{
    [SerializeField] bool IsPaused = false;
    public KeyCode pauseKey;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(pauseKey))
        {
            IsPaused = !IsPaused;

            if (IsPaused)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
        }
    }

    public void ButtonResume()
    {
        if (IsPaused)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }
}
