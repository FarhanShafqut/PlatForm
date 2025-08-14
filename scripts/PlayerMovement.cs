using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizonatalInput;
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Stats.GameOver)
        {
        if (Input.GetKey("a") && transform.position.x > -12)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (Input.GetKey("d") && transform.position.x < 12)
        {

            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!Stats.GameOver)
        {
        if(collision.collider.tag == "obstacles")
        {
            Stats.heart();
            StartCoroutine(Collision());
        }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Heart"))
        {
            Stats.life++;
        }
        if (other.CompareTag("Star"))
        {
            Stats.score++;
        }
    }
    IEnumerator Collision()
    {
        Debug.Log("working");
        Time.timeScale = 0.2f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        yield return new WaitForSeconds(0.6f);
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f;
    }
}
