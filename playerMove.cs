using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
 
    // Start is called before the first frame update

    void steeringWheel()
    {

        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 50 * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(50 * Time.deltaTime,0,0);
        }

        if (Input.GetKey("a"))
        {
            
            rb.AddForce(-50 * Time.deltaTime, 0, 0);
            
    
          
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,50* Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -50 * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }

        if (rb.position.x <= -8.4f || rb.position.x >=8.4f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (rb.position.z <=-16)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}


