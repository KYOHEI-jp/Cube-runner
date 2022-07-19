using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject obstacles;
    public Transform spawnPoint;
    int score = 0;

    // TODO 25:55
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(0.6f, 2);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacles, spawnPoint.position, Quaternion.identity);
        }
    }

    public void GameStart()
    {

        StartCoroutine("SpawnObstacles");

    }
}
