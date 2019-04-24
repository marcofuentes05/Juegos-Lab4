using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Find("Contador").gameObject.GetComponent<Text>().text = "Total targets hit: "+manager.contador;
    }

    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
