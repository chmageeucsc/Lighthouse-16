using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Turn camera off when canvas active
    public GameObject CryingStatue;

    // Enumeration describes which directions this script should control
    public enum RotationDirection { 
        None, 
        Horizontal = (1 << 0),
        Vertical = (1 << 1)
    }

    [Tooltip("Which directions this  object can rotate")]
    [SerializeField] private RotationDirection rotationDirections;
    [Tooltip("The rotation acceleration, in degrees/second")]
    [SerializeField] private Vector2 acceleration;
    [Tooltip("A multiplier to the input. Describes the max speed in degrees/second. To flip the vertical rotation, set y to negative value.")]
    [SerializeField] private Vector2 sensitivity;
    [Tooltip("The max angle from the horizon the player can rotate, in degrees")]
    [SerializeField] private float maxVerticalAngleFromHorizon;
    [Tooltip("The period to wait until resetting the input value Set this as low as possible without encountering stuttering")]
    [SerializeField] private float inputLagPeriod;

    private Vector2 velocity; // current rotation velocity, in degrees
    private Vector2 rotation; // current rotation in degrees
    private Vector2 lastInputEvent; //last received non-zero input value
    private float inputLagTimer; // the time since the last received non-zero input value

    private void OnEnable() {
        // Reset the state
        velocity = Vector2.zero;
        inputLagTimer = 0;
        lastInputEvent = Vector2.zero;

        // Calculate the current rotation by getting the gameObject's local euler angles
        Vector3 euler = transform.localEulerAngles;
        // Euler angles range from[ [0, 360), but we want [-180, 180)
        if (euler.x >= 180) {
            euler.x -= 360;
        }
        euler.x = ClampVerticalAngle(euler.x);
        // Set the angles here to clamp to the current rotation
        transform.localEulerAngles = euler;
        rotation = new Vector2(euler.y, euler.x);
    }
    
    private float ClampVerticalAngle(float angle) {
        return Mathf.Clamp(angle, -maxVerticalAngleFromHorizon, maxVerticalAngleFromHorizon);
    }

    private Vector2 GetInput() {
        if (!this.CryingStatue.activeSelf) {
            // Add to the lag timer
            inputLagTimer += Time.deltaTime;
        
            // Get the input vector. This can be changed to work with the new input system or even touch controls.
            Vector2 input = new Vector2(
                Input.GetAxis("Mouse X"),
                Input.GetAxis("Mouse Y")
            );
        
            if ((Mathf.Approximately(0, input.x) && Mathf.Approximately(0, input.y)) == false || inputLagTimer >= inputLagPeriod)
            {
                lastInputEvent = input;
                inputLagTimer = 0;
            }
        }
        return lastInputEvent;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // The wanted velocity is the current input scaled by the sensitivity
        // This is also the maximum velocity
        Vector2 wantedVelocity = GetInput() * sensitivity;

        // Zero out the unwanted velocity if this controller does not rotate in that direction
        if ((rotationDirections & RotationDirection.Horizontal) == 0) {
            wantedVelocity.x = 0;
        }
        if ((rotationDirections & RotationDirection.Vertical) == 0) {
            wantedVelocity.y = 0;
        }

        // Calculate new rotation
        velocity = new Vector2(
            Mathf.MoveTowards(velocity.x, wantedVelocity.x, acceleration.x * Time.deltaTime),    
            Mathf.MoveTowards(velocity.y, wantedVelocity.y, acceleration.y * Time.deltaTime)    
        );
        rotation += velocity * Time.deltaTime;
        rotation.y = ClampVerticalAngle(rotation.y);

        // Convert the rotation to Euler angles
        transform.localEulerAngles = new Vector3(rotation.y, rotation.x, 0);
    }
}
