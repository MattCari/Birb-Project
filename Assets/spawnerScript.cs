using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject pillar;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPillar();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPillar();
            timer = 0;
        }
    }
    void spawnPillar()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pillar, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
