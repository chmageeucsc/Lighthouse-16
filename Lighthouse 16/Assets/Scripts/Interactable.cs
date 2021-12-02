//using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    // create radius around object
    void OnDrawGizmosSelected(){
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}