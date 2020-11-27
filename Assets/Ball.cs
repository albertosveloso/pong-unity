using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float Speed = 5f;
    void Start()
    {
        float SpeedX = UnityEngine.Random.Range(0,2) == 0 ? -1 : 1;
        float SpeedY = UnityEngine.Random.Range(0,2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
