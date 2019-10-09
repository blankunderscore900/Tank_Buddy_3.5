using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbody : MonoBehaviour
{
    public GameObject WholeBlock;
    public bool isHit;
    public bool onHit;

    // Start is called before the first frame update
    void Start()
    {
        onHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        isHit = WholeBlock.GetComponent<DetectBall>().isHit;

        if (isHit == true)
        {
            if (onHit == false)
            {
                Rigidbody rb = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
                Destroy(rb, 10);
                onHit = true;
            }
        }
    }
}
