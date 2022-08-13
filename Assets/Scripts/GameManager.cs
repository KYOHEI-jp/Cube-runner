using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject obstacles;
    public Transform spawnPoint;
    int score = 0;

    //TODO 39:24
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;

    // TODO 25:55
    // Start is called before the first frame update
    void Start()
    {
        
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

    void ScoreUp()
    {
        // 42:20
        score++;
        scoreText.text = score.ToString();
    }


    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(true);

        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp", 2f, 1f);
    }
}
