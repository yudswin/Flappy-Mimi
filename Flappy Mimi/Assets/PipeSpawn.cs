using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pillar;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            SpawnPillar();
            timer = 0;
        }
    }

    void SpawnPillar() {
        Instantiate(pillar, transform.position, transform.rotation);
    }
}
