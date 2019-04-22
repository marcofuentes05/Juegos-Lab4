using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("cubo") || hitInfo.collider.CompareTag("pelota"))
                {
                    hitInfo.collider.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(hitInfo.normal*(-300), hitInfo.collider.transform.position);
                }
            }
        }
    }
}
