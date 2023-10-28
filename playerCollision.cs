using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerCollision : MonoBehaviour
{

    public playerMove movement;

    
    // detects collision
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
    }

    
}
