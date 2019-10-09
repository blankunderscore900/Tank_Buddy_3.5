using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Scrpit : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject BulletExit;
    public Vector3 mousePosition;
    public float angle;
    GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = Resources.Load("bullet") as GameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Barrel.GetComponent<Gun_rotate>().mousePosition;

        angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;

        if (Input.GetMouseButtonDown(0))
        {
            //GameObject bullet = Instantiate(gun) as GameObject;
            //bullet.transform.position = transform.position + new Vector3(angle.x, angle.y, 0) * 1;
            //Rigidbody rb = bullet.GetComponent<Rigidbody>();
            //rb.velocity = new Vector3(angle.x, angle.y, 0);

            GameObject bullet = Instantiate(gun) as GameObject;
            bullet.transform.position = BulletExit.transform.position + Camera.main.transform.localEulerAngles * 1;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.right * 500f);
            Destroy(bullet, 3);
        }
        //GameObject bullet = Instantiate(gun) as GameObject;
        //bullet.transform.position = transform.position + Camera.main.transform.right * 1;
        //Rigidbody rb = bullet.GetComponent<Rigidbody>();
        //rb.velocity = Camera.main.transform.right * 40;
    }

}
