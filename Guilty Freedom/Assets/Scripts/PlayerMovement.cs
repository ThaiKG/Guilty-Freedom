using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orien;

    float hInput;
    float VInput;

    Vector3 moveDirection;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();   
    }

    private void MyInput()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        VInput = Input.GetAxisRaw("Vertical");
    }
}
