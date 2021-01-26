using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4_Ball : MonoBehaviour
{
	
	public GameObject[] walls; 
	
	public Vector3 launchVel;
	public float coefficentOfFriction;
    // Start is called before the first frame update
	
	float time;
	
	Vector3 ballVelocity;
	
	GameObject wall;
	Vector3 wallPosition;
	
	float wallWidth;
	float ballRadius;
	
	Vector3 frictionVector;
	
    void Start()
    {
	launchVel.y = 0.0f;
	ballVelocity = launchVel;
    }

    // Update is called once per frame
    void Update()
    {
		time = Time.deltaTime;
        
		frictionVector = -VectorMathLib.scalerMultiple3DVector(VectorMathLib.unitVector3DVector(ballVelocity),coefficentOfFriction);

			if(transform.position.z > 25.0f){
				
				print("Hit Wall Top");
				
				ballVelocity.z = -ballVelocity.z;
			
				transform.position = new Vector3(transform.position.x, transform.position.y, 25.0f-(transform.position.z - 25.0f ));
				
				print(VectorMathLib.magnitude3DVector(ballVelocity));
				 
			}
			
			else if(transform.position.z < -25.0f){
				
				print("Hit Wall Top");
				
				ballVelocity.z = -ballVelocity.z;
				
				transform.position = new Vector3(transform.position.x, transform.position.y, -25.0f+(-transform.position.z - 25.0f));
				
				print(VectorMathLib.magnitude3DVector(ballVelocity));
			}
			
			else if(transform.position.x > 25.0f){
				
				print("Hit Wall Top");
				
				ballVelocity.x = -ballVelocity.x;
				
				transform.position = new Vector3(25.0f-(transform.position.x - 25.0f), transform.position.y, transform.position.z );
				
				print(VectorMathLib.magnitude3DVector(ballVelocity));
				
			}
			
			else if(transform.position.x < -25.0f){
				
				print("Hit Wall Top");
				
				ballVelocity.x = -ballVelocity.x;
				
				transform.position = new Vector3(-25.0f+(-transform.position.x - 25.0f), transform.position.y, transform.position.z );
			
				print(VectorMathLib.magnitude3DVector(ballVelocity));
			}
	
		ballVelocity += frictionVector*time;
		
		transform.position += ballVelocity*time + frictionVector*Mathf.Pow(time,2)/2;
		
    }
	
}