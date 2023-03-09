using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pillar;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn the first pillar immediately
        SpawnPillar();
    }

    // Update is called once per frame
    void Update()
    {
        // Only spawn pillars if the active scene is "gameplay"
        if (SceneManager.GetActiveScene().name == "gameplay") {
            if (timer < spawnRate) {
                timer += Time.deltaTime;
            }
            else {
                SpawnPillar();
                timer = 0;
            }
        }
    }

    void SpawnPillar() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pillar, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
