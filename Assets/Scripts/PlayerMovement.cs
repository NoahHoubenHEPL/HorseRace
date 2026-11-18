using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0.0f;
    [SerializeField] private float sidewaysSpeed = 10.0f;
    [SerializeField] private float maxSpeed = 10.0f;
    [SerializeField] private float sideMaxSpeed = 50.0f;
    [SerializeField] private Rigidbody rbPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        // rbPlayer.rotation = rbPlayer.rotation * deltaRotation;
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.Z)) || (Input.GetKey(KeyCode.S)))
        {
            if (Input.GetKey(KeyCode.Z))
            {
                speed = maxSpeed;
            }
            else
            {
                speed = -maxSpeed;
            }
        }
        else
        {
            speed = 0.0f;
        }
        if ((Input.GetKey(KeyCode.Q)) || (Input.GetKey(KeyCode.D)))
        {
            if ((Input.GetKey(KeyCode.Q)) && (Input.GetKey(KeyCode.D)))
            {
                sidewaysSpeed = 0.0f;
                rbPlayer.rotation = Quaternion.Euler(0f, 0f, 0f);
                rbPlayer.AddForce(sidewaysSpeed, 0.0f, 0.0f, ForceMode.VelocityChange);
            }
            else
            {
                if (Input.GetKey(KeyCode.Q))
                {
                    sidewaysSpeed = sideMaxSpeed / -10;
                    rbPlayer.rotation = Quaternion.Euler(0f, -30f, 0f);
                    rbPlayer.AddForce(sidewaysSpeed, 0.0f, 0.0f, ForceMode.VelocityChange);
                }
                else
                {
                    sidewaysSpeed = sideMaxSpeed / 10;
                    rbPlayer.rotation = Quaternion.Euler(0f, 30f, 0f);
                    rbPlayer.AddForce(sidewaysSpeed, 0.0f, 0.0f, ForceMode.VelocityChange);
                }
            }
        }
        else
        {
            sidewaysSpeed = 0.0f;
            rbPlayer.rotation = Quaternion.Euler(0f, 0f, 0f);
            rbPlayer.AddForce(sidewaysSpeed, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rbPlayer.AddForce(0.0f, 20.0f, 0.0f);
        }
    }
}
