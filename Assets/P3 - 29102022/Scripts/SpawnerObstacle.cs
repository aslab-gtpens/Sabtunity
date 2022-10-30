using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float timer;
    public float maxTimer;
    public float height = 2f;

    void Start()
    {
        timer = maxTimer;
    }

    private void Update()
    {
        if (timer > maxTimer)
        {
            Spawn();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void Spawn()
    {
        GameObject newObstacle = Instantiate(obstaclePrefab);
        newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height + 1), 0);
        Destroy(newObstacle, 10);
    }
}
