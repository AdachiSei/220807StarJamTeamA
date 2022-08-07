using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject EnemyPrefab;

    float span = 2.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject Enemy1 = Instantiate(EnemyPrefab) as GameObject;
            float x = Random.Range(0, 6);
            float z = Random.Range(0, 6);
            Enemy1.transform.position = new Vector3(x, 0.75f, z);
        }

    }
}
