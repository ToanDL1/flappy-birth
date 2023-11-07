using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;

    void Start()
    {
        Invoke("DestroyPipe", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }


    public void DestroyPipe()
    {
        Destroy(this);
    }



}
