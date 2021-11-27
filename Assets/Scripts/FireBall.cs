using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody ball_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ball_Rigidbody = GetComponent<Rigidbody>();
        ball_Rigidbody.AddForce(transform.up * 5000);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
