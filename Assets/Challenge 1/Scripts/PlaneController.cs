using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    //Private variables
    public float speed = 10f;
    public float tiltSpeed = 5f;
    public float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //Move forward - Constant Speed
      transform.Translate(Vector3.forward * Time.deltaTime * speed);

      //Get User Input
      verticalInput = Input.GetAxis("Vertical");

      //Move downwards - Up and Down Arrows
      transform.Rotate(Vector3.left * Time.deltaTime * tiltSpeed * verticalInput);

      //Move Sideways - Left and Right Arrows
    }
}
