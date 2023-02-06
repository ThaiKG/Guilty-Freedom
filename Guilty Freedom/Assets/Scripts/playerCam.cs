using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;

public class playerCam : MonoBehaviour
{

    public float sensX;
    public float sensY;

    public Transform orientation;
    //public Transform cameraHolder;

    float xRot;
    float yRot;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRot += mouseX;
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        //cameraHolder.rotation = Quaternion.Euler(xRot, yRot, 0);
        orientation.rotation = Quaternion.Euler(0, yRot, 0);
    }

    //public void DoFov(float endValue)
    //{
    //    GetComponent<Camera>().DOFieldOfView(endValue, 0.25f);
    //}

    //public void DoTilt(float zTilt)
    //{
    //    transform.DOLocalRotate(new Vector3(0, 0, zTilt), 0.25f);
    //}

}
