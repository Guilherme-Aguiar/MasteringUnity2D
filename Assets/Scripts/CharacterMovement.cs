using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //Instancia do componente rigidbody para o jogador
    private Rigidbody2D playerRigidBody2D;

    private float movePlayerHorizontal;
    private float movePlayerVertical;
    private Vector2 movement;

    public float speed = 4.0f;

    void Awake()
    {
        playerRigidBody2D = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerHorizontal = Input.GetAxis("Horizontal");
        movePlayerVertical = Input.GetAxis("Vertical");
        movement = new Vector2(movePlayerHorizontal, movePlayerVertical);
        playerRigidBody2D.velocity = movement * speed;
    }
}
