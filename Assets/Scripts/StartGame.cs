using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    PlayerInputActions input;
    void Awake()
    {
        input = new PlayerInputActions();
    }
    void Start()
    {
        
    }

    void Update()
    {
        var triggeredJump = input.PlayerActions.Jump.triggered;
        if(triggeredJump){
            GameManager.instance.StartGame();
        }
    }

    void OnEnable() {
        input.Enable();
    }

    void OnDisable() {
        input.Disable();
    }
}
