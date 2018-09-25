using System.Collections;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    
    public float speed;      
    public float jumpspeed, gravity;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;
   
    private void Start()
    {   
        controller = this.GetComponent<CharacterController>();
        
    }

    void Update()
    {
        

        
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpspeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


}

