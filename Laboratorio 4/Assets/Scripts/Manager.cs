using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public AudioSource one;
    public AudioSource two;
    public AudioSource fondo;
    public Slider Volume;
    public AudioClip victory;

    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }
    public int getContador()
    {
        return contador;
    }
    // Update is called once per frame
    void Update()
    {
        one.volume = Volume.value;
        two.volume = Volume.value;
        fondo.volume = Volume.value;
        Ray myRay = Camera.main.ViewportPointToRay(new Vector3 (0.5f,0.5f,0));
        RaycastHit hitInfo;
        Debug.DrawRay(transform.position, Vector3.forward, Color.blue, 30);
        if (Input.GetMouseButtonDown(0))
        {
            one.Play();
            if (Physics.Raycast(myRay, out hitInfo,Mathf.Infinity))
            {
                if (hitInfo.collider.gameObject.CompareTag("white"))
                {
                    updateScore();
                    hitInfo.collider.gameObject.GetComponent<FloatingTarget>().die();
                    hitInfo.collider.GetComponent<Rigidbody>().AddForceAtPosition(hitInfo.normal * (-600), hitInfo.collider.transform.position);
                    hitInfo.collider.GetComponent<Rigidbody>().useGravity = true;
                    Physics.gravity = new Vector3(0, -9.8f, 0);
                }
            }
        }
        if (contador == 16)
        {
            two.PlayOneShot(victory,0.7f);
            contador=0;
        }
    }

    void updateScore()
    {
        contador++;
    }
    
}
