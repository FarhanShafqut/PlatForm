using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class spwaningObstacles : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject obstaclesPrefab;
    private bool spwanBool = false;
    private bool works = false;
    public bool workUp = false;
    private int center;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Stats.GameOver)
        {
            StartCoroutine(Spwan());
        }


    }
    IEnumerator Spwan()
    {
        if (!spwanBool)
        {
            //rightside
            spwanBool = true;
            center = Random.Range(0, 4);
            if (center != 3) {

                Vector3 spwanArea = new Vector3(Random.Range(1f, 9f), 20, -0.21f);
                Instantiate(obstaclesPrefab, spwanArea, Quaternion.Euler(90f, 0f, 0f));
                if (spwanArea.x > 6.5f)
                {
                    works = true;
                }
                else
                {
                    works = false;
                }
                Vector3 offsetRightNormal = new Vector3(4.3f, 0f, 0f);
                //here is the right side 3 side
                //---

                if (spwanArea.x <= 3f)
                {
                    Debug.Log("working");
                    Vector3 offsetRight = new Vector3(8f, 0f, 0f);
                    Instantiate(obstaclesPrefab, spwanArea + offsetRight, Quaternion.Euler(90f, 0f, 0f));
                }
                else
                {
                    Instantiate(obstaclesPrefab, spwanArea + offsetRightNormal, Quaternion.Euler(90f, 0f, 0f));
                }


                //---


                //leftside


                Vector3 spwanArea1 = new Vector3(Random.Range(-9f, -1.5f), 20, -0.21f);
                Instantiate(obstaclesPrefab, spwanArea1, Quaternion.Euler(90f, 0f, 0f));
                Vector3 offsets = new Vector3(4.3f, 0f, 0f);

                //for right 3 side conditions;
                //here the left side 3 side works
                //if (works)
                //{
                if (spwanArea1.x >= -3f)
                {
                    Debug.Log("workingDown");
                    Vector3 offset1 = new Vector3(9f, 0f, 0f);
                    Instantiate(obstaclesPrefab, spwanArea1 - offset1, Quaternion.Euler(90f, 0f, 0f));
                }
                else
                {
                    Instantiate(obstaclesPrefab, spwanArea1 - offsets, Quaternion.Euler(90f, 0f, 0f));
                }
                //    works = false;

                //}
                //else
                //{
                //    Instantiate(obstaclesPrefab, spwanArea1 - offsets, Quaternion.Euler(90f, 0f, 0f));
                //}
                yield return new WaitForSeconds(3f);
            }
            else
            {
                Debug.Log("ITS ALIIVE");
                //right side
                Vector3 spwanArea = new Vector3(Random.Range(1f, 6f), 20, -0.21f);
                Vector3 offsetRightNormal = new Vector3(4.3f, 0f, 0f);
                Instantiate(obstaclesPrefab, spwanArea, Quaternion.Euler(90f, 0f, 0f));
                Instantiate(obstaclesPrefab, spwanArea + offsetRightNormal, Quaternion.Euler(90f, 0f, 0f));
                //left
                Vector3 spwanArea1 = new Vector3(Random.Range(-6f, -1.5f), 20, -0.21f);
                Instantiate(obstaclesPrefab, spwanArea1, Quaternion.Euler(90f, 0f, 0f));
                Vector3 offsets = new Vector3(4.3f, 0f, 0f);
                Instantiate(obstaclesPrefab, spwanArea1 - offsets, Quaternion.Euler(90f, 0f, 0f));
                yield return new WaitForSeconds(3f);
            }

                spwanBool = false;
        }
    }




}
