using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    string now_touch;
    Animator anim;
    int state;
    
    private CharacterController controller;
    private float speed = 12;
    private Vector3 moveDirection = Vector3.zero;
    int gravity = 2;

    void Start()
    {
        anim = GetComponent<Animator>();

        controller = GetComponent<CharacterController>();
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 0.5f);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && IsGrounded()&& now_touch=="floor")
            {
                moveDirection.y = 0.7f;
                state = 1;
            }
            else
            {
                state = 0;
            }
        moveDirection.y -= gravity * Time.deltaTime;

        anim.SetInteger("state", state);
        float axis = Input.GetAxis("Horizontal");

        controller.Move(new Vector3(axis * Time.deltaTime * 10, moveDirection.y, 0)+ Vector3.forward * speed * Time.deltaTime);
        if (transform.position.y < 0)
        {
            blood.instance.Dead();
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        now_touch = hit.gameObject.tag;

        if (hit.gameObject.tag=="barrier" && !hit.gameObject.GetComponent<obtical>().is_punch)

        {
            Debug.Log("barrier");
            blood.instance.ChangeBlood(-100);
            hit.gameObject.GetComponent<obtical>().is_punch = true;
        }
        if (hit.gameObject.tag == "monstor")
        {
            blood.instance.Dead();
        }
        //Debug.Log("碰撞");
        //Debug.Log(hit.gameObject);

    }
}
