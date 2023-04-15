using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowLava : MonoBehaviour
{
    // have this be initial amount; definitely better ways to do this
    float scaleMultiple = .001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale.y = scaleMultiple;
        transform.localScale = newScale;
        if (transform.localScale.y < 15f)
        {
            scaleMultiple += .003f;
        }
        else {
            scaleMultiple += .06f;
        }
    }
}
