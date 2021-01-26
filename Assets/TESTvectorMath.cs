using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTvectorMath : MonoBehaviour
{
	
	
	Vector3 v1 =new Vector3(3.0f,3.0f,13.0f);
	Vector3 v2 =new Vector3(10.0f,9.0f,0.0f);
	
	
	Vector3 v3 =new Vector3 (10.0f,14.0f,13.0f);
	Vector3 v4 =new Vector3 (11.0f,10.0f,0.0f);
	Vector3 v5 =new Vector3 (6.0f,14.0f,11.0f);
	Vector3 v6 =new Vector3 (0.0f,9.0f,4.0f);
	Vector3 v7 =new Vector3 (14.0f,3.0f,0.0f);
	Vector3 v8 = new Vector3(0.0f,5.0f,8.0f);
	Vector3 v9 = new Vector3(12.0f,15.0f,12.0f);
	Vector3 v10 =new Vector3 (12.0f,1.0f,9.0f);

	
	
	
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("Vector Addition : "+v1 + " Plus " + v2 + " Equals " + VectorMathLib.vectorAddition3D(v1,v2));
		Debug.Log("Vector Substraction : "+v1 + " Minus " + v2 + " Equals " + VectorMathLib.vectorSubtraction3D(v1,v2));
		
		
		Debug.Log("Vector Dot Product : "+v1 + " . " + v2 + " Equals " + VectorMathLib.dotProduct3D(v1,v2));
		
		
		Debug.Log("Unit Vector : "+ " Unit Vector of " + v2 + " Equals " + VectorMathLib.unitVector3DVector(v2));
		
		
		
		Debug.Log("Vector Reflection(Axis Aligned) : "+ " The Reflection of " + v2 + " on the x Axis is " + VectorMathLib.vectorReflectionAxisAligned2D(v2, true, false));
		
		
		Debug.Log("Cartesian to Polar : "+ " The Polar Corfinates of " + v1 + " is " + VectorMathLib.cartesianToPolar(v1));
		
		Debug.Log("Polar to Cartesian : "+ " The Cartesian Corfinates of " + (4.5f , 12.0f) + " is " + VectorMathLib.polarToCartesian(4.5f, 12.0f));
		
		
		Debug.Log("Unit Direction Vector : "+ " The Unit Direction Vector of " + v1 + " and " +v2+ "is" + VectorMathLib.getUnitDirectionVector(v1,v2));
		
		
		Debug.Log("Magnitude of 3D Vector: "+ " The Unit Magnitude of " + v1 + "is" + VectorMathLib.magnitude3DVector(v1));
		
		
		Debug.Log("Scaler Multiple of 3D Vector: "+ " The Scalar Multiple of 3D Vector " + v1  + "by" + 20.0f + "is" + VectorMathLib.scalerMultiple3DVector(v1, 20.0f));
		
		
		Debug.Log("Vectors nearly equal with radius: "+ " Cheking if " + v1  + "and" + v2 + "are close by an ammount of:" + 10.0f +":" + VectorMathLib.vectorsNearlyEquals(v1, v2, 10.0f));
		
		Debug.Log("Zero Vector"+ VectorMathLib.zeroVector3D());
		
		
		
		
		
    }

    // Update is called once per frame
    void Update()
    {
        
		
    }
	
	
	
	
	
	
	
	
	
	
	
	
}
