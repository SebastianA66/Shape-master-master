using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public float jumpHeight = 5f;
    public Rigidbody rigid;
    public float rayDistance = 1f;

    //private bool isGrounded = false;

    bool isGrounded()
    {
        Ray groundRay = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(groundRay, out hit, rayDistance))
        {
            return true;
        }
        return false;
    }

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal") * moveSpeed;
        float inputV = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 moveDir = new Vector3(inputH, 0f, inputV);


        Vector3 force = new Vector3(moveDir.x, rigid.velocity.y, moveDir.z);

        

        


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            force.y = jumpHeight;
        }

        rigid.velocity = force;

        
    }
}
