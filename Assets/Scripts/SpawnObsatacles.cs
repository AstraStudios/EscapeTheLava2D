using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsatacles : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector2 randPos = new Vector3(Random.Range(-200, 200), Random.Range(0, 200), 0);
            Instantiate(obstacle, randPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
