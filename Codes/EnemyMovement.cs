using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        transform.position += transform.right * -speed * Time.deltaTime;
    }
}
