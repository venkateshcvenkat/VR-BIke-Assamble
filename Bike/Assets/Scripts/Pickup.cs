using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] Transform holdArea;
     GameObject heldObj;
     Rigidbody heldObjRB;
    [SerializeField] private float PickupRange = 5f;
    [SerializeField] private float PickupForce = 150f;

   private void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            if (heldObj == null)
            {
                Debug.Log("enter");
                RaycastHit hit;
                if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit, PickupRange))
                {
                    
                  
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        if (heldObj != null)
        {
            MoveObject();
        }
        
    }

    void PickupObject(GameObject pickObj)
    {
      
        if (pickObj.GetComponent<Rigidbody>())
        {
            heldObj = pickObj;
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObj.transform.parent = holdArea;
          
        }
    }
    void DropObject()
    {
            heldObjRB.useGravity = true;
            heldObjRB.drag = 1;
            heldObjRB.constraints = RigidbodyConstraints.None;

            heldObj.transform.parent = null;
            heldObj = null;
        
    }
    void MoveObject()
    {
        if (Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - heldObj.transform.position);
            heldObjRB.AddForce(moveDirection * PickupForce);
        }
    }
}
