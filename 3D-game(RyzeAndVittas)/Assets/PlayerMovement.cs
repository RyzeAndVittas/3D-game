
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //here i take reference from the rigidbody and call it rb
    public Rigidbody rb;

    public float runspeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, runspeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(runspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-runspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -runspeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        

    }
}