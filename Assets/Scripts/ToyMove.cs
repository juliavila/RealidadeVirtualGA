using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyMove : MonoBehaviour {

	public const float grav = 20.0f;
	public Vector3 moveDir = Vector3.zero;
	private float speed = 3.0f;

	public Vector3 getMoveDirection()
	{
		return moveDir;
	}

	public float getSpeed()
	{
		return speed;
	}

	public void setMoveDirection(Vector3 mv)
	{
		moveDir = mv;
	}

	public void setSpeed(float s)
	{
		speed = s;
	}

	// Use this for initialization
	void Start () 
	{
		moveDir = Vector3.forward;
		gameObject.tag = "Toy";
	}
	
	// Update is called once per frame
	void Update () 
	{
		CharacterController controller = GetComponent<CharacterController> ();
		if (!controller.isGrounded) 
		{
			
			moveDir.y -= 1.0f * grav * Time.deltaTime;
		} 
		else 
		{
			moveDir.y = 0.0f;
		}
		Vector3 movement = moveDir*(speed*Time.deltaTime);
		controller.Move(movement);
	}

	void OnControllerColliderHit(ControllerColliderHit cch)
	{
		if (cch.normal.y < 0.9) // elimina colisoes com o chao
		{
			if(cch.gameObject.tag == "DirectionSign")
			{
				moveDir = cch.gameObject.GetComponent<DirectionChanger> ().getDirectionModifier ();
			}
			else
			{
			moveDir.x = moveDir.x * -1;
			moveDir.z = moveDir.z * -1;
			}
		}
	}
}
	