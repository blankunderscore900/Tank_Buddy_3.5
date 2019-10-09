using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedShard : MonoBehaviour
{
    
    public GameObject Shard;
    public bool isHit;
   
    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tank"))
        {
            Destroy(Shard);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
