using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D myRB;
    float camSize; 
    float camModify = 15;
    [SerializeField] float speedMove;
    Vector2 move;
    [SerializeField] CinemachineVirtualCamera cam;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue inputValue){
        move = inputValue.Get<Vector2>();
    }

    void OnZoom(InputAction.CallbackContext inputValue){
        camSize = inputValue.ReadValue<float>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myRB.velocity = move*speedMove;
        cam.m_Lens.OrthographicSize = camModify + camSize; //Todo Fix Camera Lens So That It Actually Zooms.
    }
}
