using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBall : MonoBehaviour
{
    public bool isHit;

    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            isHit = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
