// Lighthouse 16
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    Camera cam;
    public float speed = 5.0f;
    public bool touch = false;

    //public float rotationSpeed = 180.0f;

    void Start()
    {
        cam = Camera.main;
    }

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

        // player movement (left and right ???)
        this.transform.Translate(Input.GetAxis("Horizontal") * this.speed * 2 * Time.deltaTime, 0, 0);

        //~~~~~~~~~~~~~~~~~~~~~~~might implement this later
        /*
        if (Input.GetKeyDown("space"))
        {
        }
        */
        var transform = this.GetComponent<Transform>();
        if(transform.position.y < -1f){
            transform.position = new Vector3(0f,0f,0f);
        }
    }   
    
    // check if player is touching something
    void OnCollisionEnter(Collision collision)
    {
        // if collision is on Crying Statue
        if (collision.gameObject.name == "CryingStatue")
        {
            touch = true;
        }
    }

    // check if player is no longer touching something
    void OnCollisionExit(Collision collision)
    {
        touch = false;
    }
}