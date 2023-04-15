using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text speedDirectionText;

    [SerializeField] Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Mathf.RoundToInt(transform.position.y).ToString();
        speedDirectionText.text = rb2D.velocity.ToString();
    }
}
