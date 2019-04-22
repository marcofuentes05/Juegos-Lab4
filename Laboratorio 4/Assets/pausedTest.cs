using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausedTest : MonoBehaviour
{
    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    void pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        transform.Find("Pausa").gameObject.SetActive(true);
    }

    public void resume()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        transform.Find("Pausa").gameObject.SetActive(false);
    }
    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
        Time.timeScale = 1.0f;
    }
}
