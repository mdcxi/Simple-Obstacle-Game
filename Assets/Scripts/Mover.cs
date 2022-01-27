using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintTheInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void PrintTheInstruction ()
    {
        Debug.Log("Welcome to the game (^_^)");
        Debug.Log("Move the object by using WASD or arrow buttons");
        Debug.Log("Remember that please don't hit the walls!!!");
        Debug.Log("Hope you enjoy this game ('v')");
    }

    void MovePlayer ()
    {
        float xValue = Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Translate(xValue,0,zValue);
    }
}
