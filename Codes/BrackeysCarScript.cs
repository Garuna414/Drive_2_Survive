using UnityEngine;
using System.Collections;

public class BrackeysCarScript : MonoBehaviour
{

	public float speed = 3000f;
	public float rotationSpeed = 10f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		movement = -Input.GetAxis("Horizontal") * speed;
		rotation = Input.GetAxisRaw("Vertical");
	}

	void FixedUpdate()
	{
		if (movement == 0f)
		{
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		}
		else
		{
			backWheel.useMotor = true;
			frontWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 40000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;
		}
		float torque = Vector2.Dot(transform.right, rb.velocity) * 2f;
		rb.AddTorque(-torque);
		//rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
	}

}