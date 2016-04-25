using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	public float MotorForce;
	public float SteerAngle;
    public float BrakeForce;

	public WheelCollider FLColWheel;
	public WheelCollider FRColWheel;
	public WheelCollider BLColWheel;
	public WheelCollider BRColWheel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float accel = Input.GetAxis ("Vertical") * MotorForce;
		float steer = Input.GetAxis ("Horizontal") * SteerAngle;

		BLColWheel.motorTorque = accel;
		BRColWheel.motorTorque = accel;
        FLColWheel.motorTorque = accel;
        FRColWheel.motorTorque = accel;

		FLColWheel.steerAngle = steer;
		FRColWheel.steerAngle = steer;

        if (Input.GetKey(KeyCode.Space))
        {
            BLColWheel.brakeTorque = BrakeForce;
            BRColWheel.brakeTorque = BrakeForce;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            BLColWheel.brakeTorque = 0;
            BRColWheel.brakeTorque = 0;
        }

    }
}
