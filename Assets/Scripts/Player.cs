using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    float _speed = 1f;
    Animator playerAnimator;
    SpriteRenderer spriteRenderer;

    public GameObject attackPoint;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        attackPoint.SetActive(false);
    }


    void FixedUpdate()
    {
        /* if (Input.GetKey(KeyCode.W))
         {
             transform.Translate(new Vector3(0, 1 * _speed, 0));
             playerAnimator.SetBool("Walking", true);
             transform.localRotation = new Quaternion(0, 0, 0, 0);
         }
         if (Input.GetKey(KeyCode.S))
         {

             transform.Translate(new Vector3(0, 1 * _speed, 0));
             playerAnimator.SetBool("Walking", true);
             transform.localRotation = new Quaternion(0, 0, 180, 0);
         }*//*
         if (Input.GetKey(KeyCode.D))
         {

             *//*transform.Translate(new Vector3(-1 * _speed, 0, 0));
             playerAnimator.SetBool("Walking", true);*//*
             transform.rotation = new Quaternion(0, 0, 90, 0);
         }
         if (Input.GetKey(KeyCode.A))
         {
             *//*transform.Translate(new Vector3(1 * _speed, 0, 0));
             playerAnimator.SetBool("Walking", true);*//*
             transform.rotation = new Quaternion(0, 0, -90, 0);

         }*/

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forward = transform.up * _speed * Time.deltaTime;
            transform.position += forward;
            playerAnimator.SetTrigger("Walking");

        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0, 0, -_speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, _speed));
        }

        if (Input.GetMouseButton(0))
        {
            playerAnimator.SetTrigger("Attack");
            attackPoint.SetActive(true);
        }

    }
}
