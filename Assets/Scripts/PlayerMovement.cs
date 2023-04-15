using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertSpeed = 2.5f;
        float horizSpeed = 1.5f;
        float verticalInput = Input.GetAxis("Vertical");
        float horizInput = Input.GetAxis("Horizontal");
        playerRigidbody.AddForce(new Vector2(horizInput * horizSpeed, verticalInput * vertSpeed));
    }
}
