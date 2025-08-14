using System.Collections;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
       if (transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }

}
