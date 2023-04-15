using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsatacles : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            Vector2 randPos = new Vector3(Random.Range(-150, 150), Random.Range(10, 500), 0);
            Instantiate(obstacle, randPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
