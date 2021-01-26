using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Task4_Extension: MonoBehaviour {
	
	
	
  public GameObject[] walls;
  
  
  public GameObject ball2;
  
  
  public Vector3 launchVel;
  public float coefficentOfFriction;
  float time;
  
  Vector3 v1;
  Vector3 v2;
  
  Vector3 v1_1;
  Vector3 v2_1;
  
  
  
  GameObject wall;
  Vector3 wallPosition;
  float wallWidth;
  float ballRadius;
  Vector3 frictionVector;
  Vector3 frictionVector2;


 bool whiteHitsRed;
  
  
  void Start() {
    launchVel.y = 0.0f;
    v1 = launchVel;
	
	
	
  whiteHitsRed = true;
  }
  
  

  
  Vector3 collisionDirection;
  
  Vector3 x1;
  Vector3 x2;
  
  
  float angle;

  
 
  
  void Update() {
	  
	  
	  
	x1 = transform.position;
	x2 = ball2.transform.position;
	
    time = Time.deltaTime;
    frictionVector = -VectorMathLib.scalerMultiple3DVector(VectorMathLib.unitVector3DVector(v1), coefficentOfFriction);
	frictionVector2 = -VectorMathLib.scalerMultiple3DVector(VectorMathLib.unitVector3DVector(v2), coefficentOfFriction);
    
   
   if (x1.z > 25.0f) {
      print("Hit Wall Top");
      v1.z = -v1.z;
      x1 = new Vector3(x1.x, x1.y, 25.0f - (x1.z - 25.0f));
      print(VectorMathLib.magnitude3DVector(v1));
    }
    else if (x1.z < -25.0f) {
      print("Hit Wall Top");
      v1.z = -v1.z;
      x1 = new Vector3(x1.x, x1.y, -25.0f + ( - x1.z - 25.0f));
      print(VectorMathLib.magnitude3DVector(v1));
    }
    else if (x1.x > 25.0f) {
      print("Hit Wall Top");
      v1.x = -v1.x;
      x1 = new Vector3(25.0f - (x1.x - 25.0f), x1.y, x1.z);
      print(VectorMathLib.magnitude3DVector(v1));
    }
    else if (x1.x < -25.0f) {
      print("Hit Wall Top");
      v1.x = -v1.x;
      x1 = new Vector3( - 25.0f + ( - x1.x - 25.0f), x1.y, x1.z);
      print(VectorMathLib.magnitude3DVector(v1));
    }
   
   
	if (x2.z > 25.0f) {
      print("Hit Wall Top");
      v2.z = -v2.z;
      x2 = new Vector3(x2.x, x2.y, 25.0f - (x2.z - 25.0f));
      print(VectorMathLib.magnitude3DVector(v2));
    }
    else if (x2.z < -25.0f) {
      print("Hit Wall Top");
      v2.z = -v2.z;
      x2 = new Vector3(x2.x, x2.y, -25.0f + ( - x2.z - 25.0f));
      print(VectorMathLib.magnitude3DVector(v2));
    }
    else if (x2.x > 25.0f) {
      print("Hit Wall Top");
      v2.x = -v2.x;
      x2 = new Vector3(25.0f - (x2.x - 25.0f), x2.y, x2.z);
      print(VectorMathLib.magnitude3DVector(v2));
    }
    else if (x2.x < -25.0f) {
      print("Hit Wall Top");
      v2.x = -v2.x;
      x2 = new Vector3( - 25.0f + ( - x2.x - 25.0f), x2.y, x2.z);
      print(VectorMathLib.magnitude3DVector(v2));
    }
	
	
	
	
	if((VectorMathLib.magnitude3DVector(x1-x2) <= 1.0f)&whiteHitsRed){
		
		print("v1"+v1);
		print("v2"+v2);
		
		v1_1 = v1 -VectorMathLib.dotProduct3D(v1-v2, x1-x2)*(x1-x2)/Mathf.Pow(VectorMathLib.magnitude3DVector(x1-x2),2);
		v2_1 = v2 -VectorMathLib.dotProduct3D(v2-v1, x2-x1)*(x2-x1)/Mathf.Pow(VectorMathLib.magnitude3DVector(x2-x1),2);
	
		whiteHitsRed = false;
		
		print("v1-2"+v1_1);
		print("v2-2"+v2_1);
		
		v1_1 += frictionVector * time;
		v2_1 += frictionVector2 * time;
		
		print("3"+x1);
		x1 += v1_1 * time + frictionVector * Mathf.Pow(time, 2) / 2;
     	print("4"+x2);	
	    x2 += v2_1 * time + frictionVector2 * Mathf.Pow(time, 2) / 2;
		
		v1 = v1_1;
		v2 = v2_1;
	
	}
		
	else{
		
	v1 += frictionVector * time;
		
	v2 += frictionVector2 * time;
	x1 += v1 * time + frictionVector * Mathf.Pow(time, 2) / 2;
	x2 += v2 * time + frictionVector * Mathf.Pow(time, 2) / 2;
	
	}
	
	transform.position = x1;
	ball2.transform.position = x2;
	

  }
}