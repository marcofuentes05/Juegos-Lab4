using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    private Vector3 startPos;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        mesh.material.color = Color.cyan;
    }

    private void OnMouseExit()
    {
        mesh.material.color = Color.white;
    }
}
