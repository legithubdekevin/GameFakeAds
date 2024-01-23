using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody playerBody;
    private PlayerInput playerInput;
    private PlayerController playerController;
    private void Awake() {
        playerBody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        
        playerController = new PlayerController();
        playerController.Movement.Enable();
    }

    private void Update() {

        Vector2 inputVector = playerController.Movement.MovementKey.ReadValue<Vector2>();
        float speed = 5f;

        if (transform.position.x +inputVector.x * speed * Time.deltaTime > -2 && transform.position.x + inputVector.x * speed * Time.deltaTime < 2.5 ) {
            transform.position += new Vector3(inputVector.x, 0, 0) * speed * Time.deltaTime;
        }
    }




}
