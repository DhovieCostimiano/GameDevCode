using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    public new Rigidbody2D rigidbody{ get ; private set;}
    public float speed = 500f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        this.transform.position = Vector2.zero;
        this.rigidbody.velocity = Vector2.zero;
        
        Invoke (nameof(setTrajectory), 1f);
    }

    private void setTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range (-1f ,1f);
        force.y = -1f;

        this.rigidbody.AddForce (force.normalized * this.speed);
    }
}
