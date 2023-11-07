using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;

    private GameController m_control;
    private UI m_ui;

    private Pipe pipe;

    public float jumpSpeed;


    private void Awake()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        if (rigidBody)
        {
            Debug.Log("Hihi");
        }
        rigidBody.gravityScale = 0;
        m_control = FindObjectOfType<GameController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SoundController.instance.PlaySound("wing");
            if (m_control.GetStartGame() == false)
            {
                rigidBody.gravityScale = 5;
                m_control.Play();

            }
            UpBird();
            // Debug.Log("GetKey");
        }
    }

    public void UpBird()
    {
        this.rigidBody.velocity = Vector2.up * jumpSpeed;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("DeathZone"))
        {
            SoundController.instance.PlaySound("die");
            m_control.SetIsGameOver(true);
            m_control.SetStartGame(false);
            Destroy(gameObject);
        }




    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ScoreZone") && m_control.GetStartGame() == true)
        {
            SoundController.instance.PlaySound("point");
            m_control.IncreaseScore();

        }
    }
}
