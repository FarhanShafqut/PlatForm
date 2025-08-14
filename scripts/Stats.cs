using TMPro;
using UnityEngine;

public class Stats : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int life = 3;
    public static int score = 0;
    public static bool GameOver = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            GameOver = true;
        }
    }
    public static void heart()
    {

        life--;

    }
}
