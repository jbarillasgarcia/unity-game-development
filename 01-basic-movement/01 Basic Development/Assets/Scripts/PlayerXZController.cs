using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXZController : MonoBehaviour
{
    public float speed;
    public int edgeSize;
    public Vector3 initialPosition;

    private string direction;

    private void Awake()
    {
        Debug.Log(string.Format("@{0}::Awake", this.name));
    }

    private void Start()
    {
        Debug.Log(string.Format("@{0}::Start", this.name));

        this.speed = 5;
        this.edgeSize = 30;

        this.initialPosition = new Vector3(15, 1, -15);

        this.transform.position = this.initialPosition;

        this.direction = "left";

    }

    private void Update()
    {

        if (this.direction.Equals("left"))
        {
            if (this.transform.position.x <= this.initialPosition.x - this.edgeSize)
            {
                this.direction = "up";
            }
            else {
                this.transform.position -= this.transform.right * this.speed * Time.deltaTime;
            }            
        } 
        else if (this.direction.Equals("up"))
        {
            if (this.transform.position.z >= this.initialPosition.z + this.edgeSize)
            {
                this.direction = "right";
            }
            else
            {
                this.transform.position += this.transform.forward * this.speed * Time.deltaTime;
            }
        }
        else if (this.direction.Equals("right"))
        {
            if (this.transform.position.x >= this.initialPosition.x)
            {
                this.direction = "down";
            } 
            else
            {
                this.transform.position += this.transform.right * this.speed * Time.deltaTime;
            }
        }
        else if (this.direction.Equals("down"))
        {
            if (this.transform.position.z <= this.initialPosition.z)
            {
                this.direction = "left";
            } 
            else
            {
                this.transform.position -= this.transform.forward * this.speed * Time.deltaTime;
            }
        }
        
    }
}
