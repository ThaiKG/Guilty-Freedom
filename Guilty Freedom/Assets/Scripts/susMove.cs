using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAlpha : MonoBehaviour
{

    public float speed;
    public float rotateSpeed;

    private CharacterController charControl;

    // Start is called before the first frame update
    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticleInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticleInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        //transform.Translate(magnitude * speed * Time.deltaTime * movementDirection, Space.World);

        charControl.SimpleMove(movementDirection* magnitude);

        if(movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);
        }
    }
}
