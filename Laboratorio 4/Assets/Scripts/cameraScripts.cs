using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScripts : MonoBehaviour
{
    bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                resume();
            }
            else {
                pause(); 
            }
                
        }
    }
    public void resume()
    {
        transform.Find("MainCamera").Find("Pausa").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPause = false;
    }

    public void pause()
    {
        transform.Find("MainCamera").Find("Pausa").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPause = true;
    }
}
