using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = -1000f;
    public float sideforce = 5f;
    public float forwardforce2 = -500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardforce * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, sideforce * Time.deltaTime, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -sideforce * Time.deltaTime, ForceMode.VelocityChange);

        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(forwardforce2 * Time.deltaTime, 0, 0, ForceMode.Impulse);

        }
        if (rb.position.y < -3f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
        if (Input.GetKey("j"))
        {
            rb.AddForce(0 ,-forwardforce2 * Time.deltaTime, 0, ForceMode.Impulse);

        }
    }
} 
