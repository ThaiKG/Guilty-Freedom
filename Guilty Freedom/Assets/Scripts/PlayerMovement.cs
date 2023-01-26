using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private CapsuleCollider coll;
    [SerializeField] float rot = 5;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    float speed = 5.0f;

    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        transform.position = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        //groundedPlayer = controller.isGrounded;
        //if (groundedPlayer && playerVelocity.y < 0)
        //{
        //    playerVelocity.y = 0f;
        //}
        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //}

        //// Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);
    }
}
