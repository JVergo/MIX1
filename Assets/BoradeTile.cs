using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoradeTile : MonoBehaviour
{
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.color = color;
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }
}
