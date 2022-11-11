using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 1f;
    float rotateSpeed = 0.3f;
    float Move_X;
    float Move_Z;
    float XRot = 0;
    float YRot = 0;
    Vector3 MoveDir;
    CharacterController CC;
    public Camera PlayerCam;

    // Start is called before the first frame update
    void Start()
    {
        CC = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        int cnt = 0;
        Moving();
        while (cnt < 6)
        {
            Rotating();
            cnt++;
        }

    }
    void Rotating()
    {
        XRot += Input.GetAxis("Mouse Y") * rotateSpeed;
        XRot = Mathf.Clamp(XRot, -90, 90);
        YRot += Input.GetAxis("Mouse X") * rotateSpeed;
        PlayerCam.transform.rotation = Quaternion.Euler(-XRot, YRot, 0);
        transform.rotation = Quaternion.Euler(0, YRot, 0);

    }
    void Intreract() 
    {
        Debug.Log("Interacted");
    }
    void Moving() 
    {
        Move_X = Input.GetAxis("Horizontal");
        Move_Z = Input.GetAxis("Vertical");
        MoveDir = new Vector3(Move_X, -1f, Move_Z);
        MoveDir = transform.TransformDirection(MoveDir);
        CC.Move(MoveDir * Time.deltaTime* speed);

    }
}
