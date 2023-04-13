using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMovement : MonoBehaviour
{
    Rigidbody2D myRB;
    //Vector2 bossAI;
    //int bossX = 0;
    //int bossY = 0;
    [SerializeField] float step = 0.000000000000001f;
    [SerializeField] Transform playerPos;
    Vector2 target;
    bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        //StartCoroutine(moveBoss());
    }

    // Update is called once per frame
    void Update()
    {
        
        target = new Vector2(playerPos.position.x, playerPos.position.y);
        //bossAI = (bossX, bossY);
        transform.position = Vector2.MoveTowards(transform.position, target, (step)*Time.deltaTime);
        
        
    }
}
