using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D myRB; 
    float camModify = 6;
    float cameraSize;
    [SerializeField] float speedMove;
    Vector2 move;
    [SerializeField] CinemachineVirtualCamera cam;
    [SerializeField] PlayerInput pi;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue inputValue){
        move = inputValue.Get<Vector2>();
    }

    public void OnZoom(InputValue inputValue){
       cameraSize = inputValue.Get<float>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myRB.velocity = move*speedMove;
        if((cameraSize != 0f) && (camModify < 12f && camModify > 2f)){
           camModify = camModify + (cameraSize*0.1f);
           if(camModify >= 12f){
            camModify = 11f;
            cameraSize = 0f;
           } else if(camModify <= 2f){ 
            camModify = 3f;
            cameraSize = 0f;
            }
        }
        cameraSize = 0f;
        cam.m_Lens.OrthographicSize = camModify;
        
         //Todo Fix Camera Lens So That It Actually Zooms.
    }
}
