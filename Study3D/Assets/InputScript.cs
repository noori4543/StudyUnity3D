using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public float moveSpeed = 5;
    float moveX = Input.GetAxisRaw("Horizontal");
    float moveZ = Input.GetAxisRaw("Vertical");

    public Animator anicon_Santa;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.A)) // 'A'를 누르면 왼쪽 
        {
           moveDirection += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D)) // 'D'를 누르면 오른쪽 
        {
            moveDirection += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.W)) // 'W'를 누르면 앞 
        {
            moveDirection += new Vector3(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.S)) // 'S'를 누르면 뒤 
        {
            moveDirection += new Vector3(0, 0, -1);
        }

        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;

        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }

        bool isWalk = 0 < moveDirection.magnitude;

        anicon_Santa.SetBool("ISWALK", isWalk);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anicon_Santa.SetTrigger("ATTACK");
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            anicon_Santa.SetTrigger("JUMPATTACK");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anicon_Santa.SetTrigger("LeftMouse");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            anicon_Santa.SetTrigger("RightMouse");
        }
    }
}
