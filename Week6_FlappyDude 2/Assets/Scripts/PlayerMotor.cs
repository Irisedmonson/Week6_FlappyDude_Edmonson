using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour
{
    public Rigidbody2D PlayerRB;
    public float JumpSpeed = 15;
    public GameObject GameOverCanvas;

    public int CurrentScore;
    public Text ScoreText;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space)) 
        {
            // Debug.Log ("Space");
            PlayerRB.velocity = new Vector2(PlayerRB.velocity.x , JumpSpeed);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOverCanvas.SetActive (true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CurrentScore++;
        ScoreText.text = CurrentScore.ToString();
    }
}
