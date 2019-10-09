using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTankOnGround : MonoBehaviour
{
    public bool tankIsOnGround; 
    
    // Start is called before the first frame update
    void Start()
    {
        tankIsOnGround = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tank")) tankIsOnGround = true;
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Tank")) tankIsOnGround = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
