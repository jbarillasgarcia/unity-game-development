using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int distance;

    void Update()
    {
        this.transform.position += this.transform.forward * this.speed * Time.deltaTime;

        if (this.transform.position.z >= this.distance || this.transform.position.z <= 0)
        {
            this.speed *= -1;
        }
    }
}
