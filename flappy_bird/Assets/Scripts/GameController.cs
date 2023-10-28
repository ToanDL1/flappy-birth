using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject PipePrefabs;

    double TimeCreate;




    // Start is called before the first frame update
    void Start()
    {
        TimeCreate = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCreate -= Time.deltaTime;
        if (TimeCreate <= 0)
        {
            CreatePipe();
            TimeCreate = 2;
        }
    }
    public void CreatePipe()
    {
        Vector2 PipePos = new Vector2(11, Random.Range((float)-4.5, (float)-2.75));
        if (PipePrefabs)
        {
            Instantiate(PipePrefabs, PipePos, Quaternion.identity);
        }
    }
}
