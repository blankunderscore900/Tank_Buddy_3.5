using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject IsTankOnGround;
    public bool tankIsOnGround;
    public float speedInput;
    float speed;
    private Rigidbody rb;
    public Transform CameraHolder;
    public bool faceLeft;
    public bool faceRight;

    public AudioSource TankSound;

    // Start is called before the first frame update
    void Start()
    {
        tankIsOnGround = false;
        rb = GetComponent<Rigidbody>();
        faceLeft = false;
        faceRight = true;    
    }

    // Update is called once per frame
    void Update()
    {
        tankIsOnGround = IsTankOnGround.GetComponent<IsTankOnGround>().tankIsOnGround;
        if (tankIsOnGround == true) speed = speedInput;
        else speed = 0;

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);

        rb.AddForce(movement * speed);

        CameraHolder.transform.position = gameObject.transform.position;

        if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            faceLeft = true;
            faceRight = false;
            TankSound.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A)) TankSound.Stop();

        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            faceRight = true;
            faceLeft = false;
            TankSound.Play();
        }
        else if (Input.GetKeyUp(KeyCode.D)) TankSound.Stop(); 
        
    }
}
