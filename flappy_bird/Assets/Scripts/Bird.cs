using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;

    public float jumpSpeed;

    private void Awake()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        if (rigidBody)
        {
            Debug.Log("Hihi");
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            UpBird();
            Debug.Log("GetKey");
        }
    }

    public void UpBird()
    {
        this.rigidBody.velocity = Vector2.up * jumpSpeed;
    }
}
