using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMotor : MonoBehaviour
{
    public float moveSpeed = 5;
    public float despawnXPosition = -18;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < despawnXPosition)
        {
            Destroy(gameObject);
        }
    }
}
