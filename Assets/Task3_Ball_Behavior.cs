using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3_Ball_Behavior: MonoBehaviour {

  public GameObject[] wpArray;

  //	public GameObject[2] Bodies; 

  public float Speed;
  public float Radius;

  private float time = 0.0f;

  int currentObject;
  // Start is called before the first frame update	

  GameObject obj;
  Vector3 gameObjPosition;

  bool rotationState = false;

  //	rotationState = false;

  float degreeCount = 0.0f;

  //	degreeCount = 0.0f;

  private float numberOfDegreesPerSecond;

  void Start() {
    numberOfDegreesPerSecond = (Speed / Radius);
    currentObject = 0;
  }

  // Update is called once per frame
  void Update() {

    time = Time.deltaTime;

    //	VectorMathLib.get
    obj = wpArray[currentObject];

    gameObjPosition = obj.transform.position;

    if (rotationState) {

      transform.RotateAround(obj.transform.position, Vector3.up, 90 * time);

      degreeCount += (90 * time);

      if (degreeCount >= 360) {

        rotationState = false;

        currentObject += 1;
        if (currentObject == (wpArray.Length)) {
          currentObject = 0;
        }

        degreeCount = 0.0f;
      }

    } else {

      transform.position += Speed * VectorMathLib.getUnitDirectionVector(transform.position, gameObjPosition);

      if (VectorMathLib.vectorsNearlyEquals(transform.position, gameObjPosition, Radius)) {

        rotationState = true;

      }

    }

  }
}