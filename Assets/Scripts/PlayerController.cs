using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    float speed = 30;
    float rotSpeed = 80;
    float rot = -48;
    float gravity = 8;
    float backupSpeed = 5;
    Vector3 startPos;

    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;
    Transform trans;

    private AnimatorStateInfo currentBaseState;
    private CapsuleCollider col;
    static int runState = Animator.StringToHash("isRunning");
    
    public AudioSource SlashSE;

    void Start()
    {
        SlashSE.volume=0;
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        startPos = transform.position;
        
    }
    void FixedUpdate(){
        
    }
    void Update()
    {
        /*
        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * rotSpeed;

        this.gameObject.transform.Translate(0, 0, z);
        this.gameObject.transform.Rotate(0, y, 0);

        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isShooting", false);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isShooting", false);
            this.gameObject.transform.Translate(0, 0, -z);
        }
        if (Input.GetAxis("Vertical") == 0)
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isShooting", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isShooting", true);
            SlashSE.volume = 1;
            SlashSE.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isShooting", false);
            SlashSE.volume = 0;
        }
        anim.SetBool("isShooting", false);
        */
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isShooting", false);
            moveDir = new Vector3(0, 0, 1);
            moveDir *= speed;
            moveDir = transform.TransformDirection(moveDir);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isShooting", false);
            moveDir = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isShooting", true);
            moveDir = new Vector3(0, 0, 0);
            SlashSE.volume=1;
            SlashSE.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isShooting", false);
            moveDir = new Vector3(0, 0, 0);
            SlashSE.volume=0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("isRunning", true);
            moveDir = new Vector3(0, 0, -1);
            moveDir *= speed;
            moveDir = transform.TransformDirection(moveDir);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("isRunning", false);
            moveDir = new Vector3(0, 0, 0);
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
}
