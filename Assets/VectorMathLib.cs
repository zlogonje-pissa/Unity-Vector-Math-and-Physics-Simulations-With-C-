using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class VectorMathLib : MonoBehaviour
{
 
	
	// 12 Functions for Task 1
	
	// v1, v2 are variable names for First Vector and Second Vector
	
	//Addition of 2 Vectors
  public static Vector3 vectorAddition3D(Vector3 v1, Vector3 v2) {
	// 3D Vector Addition Function
    return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
  }


// Substraction of 2 Vectors
  public static Vector3 vectorSubtraction3D(Vector3 v1, Vector3 v2) {
    return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
  }


// Dot Product of 2 Vectors
  public static float dotProduct3D(Vector3 v1, Vector3 v2) {
    return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
  }


// Unit Vector of a Vector
  public static Vector3 unitVector3DVector(Vector3 v1) {
	float v1Magnitude;  
	v1Magnitude = Mathf.Sqrt(Mathf.Pow(v1.x,2)+Mathf.Pow(v1.y,2)+Mathf.Pow(v1.z,2));
	if(v1Magnitude>0.0f){
		return new Vector3(v1.x / v1Magnitude, v1.y / v1Magnitude, v1.z / v1Magnitude);
	}
	else{
		return new Vector3();
	}
  }



  // Axis Aligned 2D Vector Reflection, Assuming there is no Movement in the y Axis, Only 1 Axis at a Time
  public static Vector3 vectorReflectionAxisAligned2D(Vector3 v1, bool xCollision, bool zCollision) {
    Vector3 reflectedVector = new Vector3();
    if (xCollision == true) { // xCollision = True, Means that the Object Hits the xAxis
      reflectedVector.x = v1.x;
      reflectedVector.y = v1.y;
      reflectedVector.z = -v1.z;
	}

    if (zCollision == true) { // zCollision = True, Means that the Object Hits the zAxis
      reflectedVector.x = -v1.x;
      reflectedVector.y = v1.y;
      reflectedVector.z = v1.z;
    }
    return reflectedVector;
  }
  
  
  
  // 3D Vector Reflection, Only 1 Plane at a Time
  public static Vector3 vectorReflectionAxisAligned3D(Vector3 v1, bool xzCollision, bool xyCollision, bool zyCollision) {
    Vector3 reflectedVector = new Vector3();
    if (xzCollision == true) { // xzCollision = True, Means that the Object Hits the xzPlane
      reflectedVector.x = v1.x;
      reflectedVector.y = -v1.y;
      reflectedVector.z = v1.z;
    }

    if (xyCollision == true) { // xzCollision = True, Means that the Object Hits the xyPlane
      reflectedVector.x = v1.x;
      reflectedVector.y = v1.y;
      reflectedVector.z = -v1.z;
    }
	
    if (zyCollision == true) { // zyCollision = True, Means that the Object Hits the zyPlane
      reflectedVector.x = -v1.x;
      reflectedVector.y = v1.y;
      reflectedVector.z = v1.z;
    }
    return reflectedVector;
  }  


	public static Vector2 polarToCartesianUnitVector(float angleInRadians)
	 {
		  return new Vector2(Mathf.Sin(angleInRadians), Mathf.Cos(angleInRadians));
	 }
 
 

	public static Vector2 polarToCartesian(float magnitude, float angleInRadians){
		Vector2 cartesianCordinates = new Vector2();
			
		cartesianCordinates.x = magnitude*Mathf.Cos(angleInRadians);
		cartesianCordinates.y = magnitude*Mathf.Sin(angleInRadians);
	
		return cartesianCordinates;
	}
	


	public static float[] cartesianToPolar(Vector2 v1){
		float magnitude;
		float angleInRadians;
    float[] polarCord = new float[2];
		
		magnitude = Mathf.Sqrt(Mathf.Pow(v1.x,2)+Mathf.Pow(v1.y,2));
		angleInRadians = Mathf.Atan(v1.y/v1.x);
		
    polarCord[0] = magnitude;
    polarCord[1] = angleInRadians;

    return polarCord;
	}



	public static Vector3 getDirectionVector(Vector3 v1, Vector3 v2){
		Vector3 v3;
		v3.x = v2.x-v1.x;
		v3.y = v2.y-v1.y;
		v3.z = v2.z-v1.z;
		
		return v3;
	}

	public static Vector3 getUnitDirectionVector(Vector3 v1, Vector3 v2){
		Vector3 v3;
		v3.x = v2.x-v1.x;
		v3.y = v2.y-v1.y;
		v3.z = v2.z-v1.z;
	
		
		return unitVector3DVector(v3);
	}

  public static float magnitude3DVector(Vector3 v1) {
    return Mathf.Sqrt(Mathf.Pow(v1.x, 2) + Mathf.Pow(v1.y, 2) + Mathf.Pow(v1.z, 2));
  }
  
  public static Vector3 scalerMultiple3DVector(Vector3 v1, float scaler) {
    return new Vector3(scaler * v1.x, scaler * v1.y, scaler * v1.z);
  }
  
  
  
  public static bool vectorsNearlyEquals(Vector3 v1, Vector3 v2, float toleranceAmount) {
    return magnitude3DVector(vectorSubtraction3D(v1, v2)) < Mathf.Abs(toleranceAmount);
  }


  public static Vector3 zeroVector3D() {
    return new Vector3(0.0f,0.0f,0.0f);
  }
  
 
 
 
 
 
  public static bool pointIsOnAAxisAlignedLine(Vector3 point, Vector3 line) {
	
	

	return true;
	
	
	
	
	
	
 }
  
}
