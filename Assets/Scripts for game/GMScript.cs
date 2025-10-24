using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GMScript : MonoBehaviour
{
    public TextMeshProUGUI GameOverText;
    public GameObject SpaceShip;
    public GameObject Enemy;
    public List<Vector3> EnemyPos;
    public GameObject Asteroid;
    private float RespawnTimer;
    private float Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOverText.gameObject.SetActive(false);
        RespawnTimer =1.75f;
        Timer =0;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= RespawnTimer && SpaceShip.gameObject.activeSelf)
        {
            SpawnNewEnemies();
            Timer =0;
        }
    }

    void SpawnNewEnemies()
    {
        Instantiate(Enemy, EnemyPos[Random.Range(0, EnemyPos.Count)], Quaternion.identity);
    }
    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
    }
}