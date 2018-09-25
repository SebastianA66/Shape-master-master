using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseLook : MonoBehaviour
{


    public RotationalAxis axis = RotationalAxis.MouseX;


    public float sensitivityX = 10f;
    public float sensitivityY = 10f;


    public float minumumY = -60f;
    public float maximumY = 60f;

    float rotationY = 0.0f;



    private void Update()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.LookAt(mousePos);

        #region Mouse X and Y
        
        if (axis == RotationalAxis.MouseXandY)
        {
            
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
            
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            
            rotationY = Mathf.Clamp(rotationY, minumumY, maximumY);
            
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        
        
        else if (axis == RotationalAxis.MouseX)
        {
        
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX * Time.deltaTime, 0);
        }
        
        
        else
        {
        
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        
            rotationY = Mathf.Clamp(rotationY, minumumY, maximumY);
        
            transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
        
        }

        
    }
}


public enum RotationalAxis
{
    MouseXandY,
    MouseX,
    MouseY
}
#endregion