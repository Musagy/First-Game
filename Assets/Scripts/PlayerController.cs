using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    
    private Rigidbody2D playerRB;
    private Vector2 moveInput;
    private Animator playerAni;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAni = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

    
        playerAni.SetFloat("Horizontal", moveX);
        playerAni.SetFloat("Speed X", moveInput.x * moveInput.x);
    }

    private void FixedUpdate()
    {
        playerRB.MovePosition(
            playerRB.position + moveInput * speed * Time.fixedDeltaTime
        );
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Colisión chupapi");
    }
}
