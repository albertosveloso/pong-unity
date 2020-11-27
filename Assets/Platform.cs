using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float Speed = 7f;
    public bool isRight;

    void Update()
    {
        if(isRight)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * Speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * Speed * Time.deltaTime, 0f);
        }
        
    }
}
