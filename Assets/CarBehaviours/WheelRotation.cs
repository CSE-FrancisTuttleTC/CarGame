using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    [Tooltip("A float value determining the max speed this car can go forwards or backwards.")]
    [SerializeField] private float maxSpeed = 450f;
    [Tooltip("A float value determining how fast the car accelerates.")]
    [SerializeField] private float acceleration = 360f;
    [Tooltip("A float value determining how fast the car decelerates.")]
    [SerializeField] private float deceleration = 360f;

    private float speed, moveInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float targetSpeed; // Target speed to accelerate / decelerate towards.
        
        moveInput = Input.GetAxisRaw("Vertical"); // Get Vertical input.

        targetSpeed = moveInput * maxSpeed;

        // Acelerate / decelerate towards target speed.
        if (targetSpeed > speed) speed = Mathf.MoveTowards(speed, targetSpeed, acceleration * Time.deltaTime);
        else speed = Mathf.MoveTowards(speed, targetSpeed, deceleration * Time.deltaTime);

        transform.Rotate(Vector3.left * speed * Time.deltaTime, Space.Self);
    }
}
