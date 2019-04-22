using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
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
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        Debug.DrawRay(transform.position, Vector3.forward, Color.blue, 30);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("white"))
                {
                    updateScore();
                    hitInfo.collider.gameObject.GetComponent<FloatingTarget>().die();
                    hitInfo.collider.GetComponent<Rigidbody>().AddForceAtPosition(hitInfo.normal * (-600), hitInfo.collider.transform.position);
                    hitInfo.collider.GetComponent<Rigidbody>().useGravity = true;
                    Physics.gravity = new Vector3(0, -9.8f, 0);
                    //Destroy(hitInfo.collider.gameObject, 0.6f);
                }
            }
        }
        if (contador == 12)
        {

        }
    }

    void updateScore()
    {
        contador++;
    }
    
}
