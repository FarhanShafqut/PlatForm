using UnityEngine;

public class spwaningUpgrades : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] upgrades;
    private int randomUpgrades;
    public int speed;
    //public float rotation = 
    void Start()
    {
        InvokeRepeating(nameof(upgradesSpwan), 2f, 7f);
    }
    void wave()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void upgradesSpwan()
    {
        Vector3 spwanArea = new Vector3(Random.Range(-12, 12), 20, -0.21f);
        randomUpgrades = Random.Range(0, upgrades.Length);
        Instantiate(upgrades[randomUpgrades], spwanArea, Quaternion.Euler(0f, 0f, 0f));
    }
}
