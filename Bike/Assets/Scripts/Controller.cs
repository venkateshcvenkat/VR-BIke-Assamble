using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private float inputx, inputy;
    private float currentSteeringAngle, currentBreakForce;
    private bool isBreaking;
    public float accelearation, breakForce, maxsteerAngle;
    public Transform FWwheeltransform, BWwheeltransform;
    public WheelCollider FWCollider, BWCollider;


    private void FixedUpdate()
    {
        GetInput();
        carAccelearation();
        carBreak();
        CarSteering();
        RotateWheels();
    }
    public void GetInput()
    {
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");
        isBreaking = Input.GetKey(KeyCode.Space);
    }
    public void carAccelearation()
    {
        FWCollider.motorTorque = inputy * accelearation;
        
        BWCollider.motorTorque = inputy * accelearation;
        currentBreakForce = isBreaking ? breakForce : 0f;
        carBreak();

    }
    public void carBreak()
    {
        FWCollider.brakeTorque = currentBreakForce;
       
        BWCollider.brakeTorque = currentBreakForce;
    }
    public void CarSteering()
    {
        currentSteeringAngle = inputx * maxsteerAngle;
        FWCollider.steerAngle = currentSteeringAngle;
        
    }
  public void RotateWheels()
    {
        UpdateWheels(FWCollider, FWwheeltransform);
        
        UpdateWheels(BWCollider, BWwheeltransform);
    }
    public void UpdateWheels(WheelCollider collider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        collider.GetWorldPose(out pos, out rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;

    }
}
