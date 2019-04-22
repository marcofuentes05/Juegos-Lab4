using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTarget : MonoBehaviour
{
    private Vector3 startPos;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Rotate(0, Time.deltaTime * 50, 0);
            transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time) / 3, 0);
        }
        else
        {
            
        }
    }
    public void die()
    {
        isAlive = false;
    }
    
}
