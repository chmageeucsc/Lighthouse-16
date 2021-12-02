// Lighthouse 16

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    //public float rotationSpeed = 180.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*// player rotation (left and right)
        var transform = this.GetComponent<Transform>();
        var rotationInput = Input.GetAxis("Horizontal");
        transform.localRotation *= Quaternion.Euler(
            0.0f,
            rotationInput * this.rotationSpeed * Time.deltaTime,
            0.0f
        );*/

        // player movement (forward and backward)
        var delta = Input.GetAxis("Vertical") * this.speed * this.GetComponent<Transform>().forward;
        this.GetComponent<CharacterController>().SimpleMove(delta);
    }
}
