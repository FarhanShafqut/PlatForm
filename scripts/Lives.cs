using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI lives;
    public TextMeshProUGUI score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = Stats.life.ToString("0");
        score.text = "Score: " + Stats.score.ToString("0");
        if (Stats.GameOver)
        {
            lives.text = "Game over";
        }
    }
}
