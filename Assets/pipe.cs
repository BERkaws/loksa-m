using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    float nilairandom;
    void Start()
    {
         nilairandom= Random.Range(-3.73f, -0.35f);
            transform.position = new Vector2(transform.position.x, nilairandom);
    }

   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left *100, Time.deltaTime * 5);
    }
}
