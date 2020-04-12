using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    //キャラクターコントローラーを格納する変数
    CharacterController characterController;

    Vector3 moveDirection = new Vector3(0, 0, 0);

    //アニメーターを格納する変数
    Animator animator;

    public float gravity = 0.002f;

    public float JumpPower = 0.012f;

    //スピード
    public float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
    characterController = GetComponent<CharacterController>();

    animator = GetComponent<Animator>();
    
    }
    

// Update is called once per frame
    void Update()
{
    if (Input.GetMouseButtonDown(0))
    {

        JumpPlayer();

    }

        WalkPlayer();

    characterController.Move(moveDirection);

    moveDirection.y -= gravity;
}
    //プレイヤーを前に進ませる

    void WalkPlayer()
    {
        moveDirection.z = speed;

        animator.SetBool("walk", moveDirection.z > 0);
    }

    void JumpPlayer()
    {
        moveDirection.y = JumpPower;
    }

}