using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_rotate : MonoBehaviour
{
    public Vector3 mousePosition;
    public float angle;

    public float angleMinFacingLeft;
    public float angleMaxFacingLeft;
    public float angleMinFacingRight;
    public float angleMaxFacingRight;

    public GameObject Tank;
    public bool facingLeft;
    public bool facingRight;

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse_pos = Input.mousePosition;
        Vector3 player_pos = Camera.main.WorldToScreenPoint(this.transform.position);

        mouse_pos.x = mouse_pos.x - player_pos.x;
        mouse_pos.y = mouse_pos.y - player_pos.y;

        mousePosition = mouse_pos;

        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


        facingLeft = Tank.GetComponent<Movement>().faceLeft;
        facingRight = Tank.GetComponent<Movement>().faceRight;
        
        if (facingLeft)
        {
            Tank.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));

            if (angle > angleMinFacingLeft && angle < 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, angleMinFacingLeft));
            }
            if (angle < angleMaxFacingLeft && angle > 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, angleMaxFacingLeft));
            }
        }
        if (facingRight)
        {
            Tank.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

            if (angle < angleMinFacingRight)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, angleMinFacingRight));
            }
            if (angle > angleMaxFacingRight)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, angleMaxFacingRight));
            }
        }
        
    }
}
