using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float forceToJump = 1f;
    [SerializeField] private float rotationVelocity = 5f; 
    PlayerInputActions input;
    Rigidbody2D rigidBody;
    void Awake()
    {
        input = new PlayerInputActions();
    }

    void Start(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var triggeredJump = input.PlayerActions.Jump.triggered;
        if(triggeredJump){
            rigidBody.velocity = Vector2.up * forceToJump;
        }
    }

    void FixedUpdate() {
        transform.rotation = Quaternion.Euler(0, 0, rigidBody.velocity.y * rotationVelocity);
    }

    void OnEnable() {
        input.Enable();
    }

    void OnDisable() {
        input.Disable();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("InsidePipe")) {
            GameManager.instance.UpdateScore();
        }

        if(collider.gameObject.CompareTag("Obstacle")) {
            GameManager.instance.GameOver();
        }
    }
}
