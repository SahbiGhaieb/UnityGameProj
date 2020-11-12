using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlatformTile : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public GameObject[] obstacles; //Objects that contains different obstacle types which will be randomly activated
    public GameObject[] collectibles;

    public void ActivateRandomObstacle()
    {
        DeactivateAllObstacles();

        System.Random random = new System.Random();
        int randomNumber = random.Next(0, obstacles.Length);
        obstacles[randomNumber].SetActive(true);
    }

    public void DeactivateAllObstacles()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(false);
        }
    }

    public void ActivateRandomCollectible()
    {
        DeactivateAllCollectibles();

        System.Random random = new System.Random();
        int randomNumber = random.Next(0, obstacles.Length);
        collectibles[randomNumber].SetActive(true);
    }

    public void DeactivateAllCollectibles()
    {
        for (int i = 0; i < collectibles.Length; i++)
        {
            collectibles[i].SetActive(false);
        }
    }
}