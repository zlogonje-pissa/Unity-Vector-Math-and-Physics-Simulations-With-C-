using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere: MonoBehaviour {
  public Vector3 launchVel;
  public float E;

  Vector3 gravity;

  private float time = 0.0f;
  // Time.deltaTime step;
  // Start is called before the first frame update
  ///COFEICENT OF RESTITUTION : |VELOCITY AFTER|/|VELOCITY BEFORE|;
  /// COFEICENT of RESTITUTION = SquareRoot(HeightAfter/HeightBefore);

  Vector3 velocity;

  float maxHeight;

  void Start() {
    gravity = new Vector3(0.0f, -9.81f, 0.0f);

    velocity = launchVel;
    maxHeight = (Mathf.Pow(velocity.y, 2) / (2 * gravity.y));

  }

  // Update is called once per frame
  void Update() {

    time = Time.deltaTime;

    velocity = velocity + gravity * time;
    transform.position += (velocity * time + (gravity * Mathf.Pow(time, 2) / 2));

    if (transform.position.y < 0f) {

      transform.position = new Vector3(transform.position.x, -transform.position.y, transform.position.z);

      velocity.y = Mathf.Sqrt(2 * (gravity.y) * (maxHeight - transform.position.y));

      if (-maxHeight < 0.01f) {
        maxHeight = 0.0f;
        velocity = new Vector3(0.0f, 0.0f, 0.0f);

      } else {
        print("Max Height: " + (-maxHeight));
        maxHeight = maxHeight * Mathf.Pow(E, 2);
      }

    }

    //Velocity multiplied by 1 Frame
    // velocity += gravity*Time.deltaTime;                                                                             
  }

}