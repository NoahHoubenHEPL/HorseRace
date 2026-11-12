using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float sidewaysSpeed = 10.0f;
    [SerializeField] private float spinSpeed = 10.0f;
    [SerializeField] private float jumpPower = 10.0f;
    [SerializeField] private Rigidbody rbPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(sidewaysSpeed, jumpPower, speed);
        Quaternion deltaRotation = Quaternion.Euler(0f, spinSpeed, 0f);
        // rbPlayer.rotation = rbPlayer.rotation * deltaRotation;
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.Z)) || (Input.GetKey(KeyCode.S)))
        {
            if (Input.GetKey(KeyCode.Z))
            {
                speed = 50.0f;
            }
            else
            {
                speed = -50.0f;
            }
        }
        else
        {
            speed = 0.0f;
        }
        if ((Input.GetKey(KeyCode.Q)) || (Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKey(KeyCode.Q))
            {
                sidewaysSpeed = -30.0f;
                rbPlayer.rotation = Quaternion.Euler(0f, -30f, 0f);
            }
            else
            {
                sidewaysSpeed = 30.0f;
                rbPlayer.rotation = Quaternion.Euler(0f, 30f, 0f);
            }
        }
        else
        {
            sidewaysSpeed = 0.0f;
            rbPlayer.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
