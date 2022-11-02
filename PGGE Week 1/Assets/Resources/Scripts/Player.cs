using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator anim;
    CharacterController controller;

    public float walk = 1.0f;
    public float rotateSpeed = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float speed = walk;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = walk * 2.0f;
        }

        if (anim == null)
            return;

        transform.Rotate(0.0f, h * rotateSpeed * Time.deltaTime, 0.0f);

        Vector3 forward = transform.forward;
        forward.y = 0.0f;

        anim.SetFloat("PosX", 0);
        anim.SetFloat("PosZ", v * speed / (2.0f * walk));

    }
}

