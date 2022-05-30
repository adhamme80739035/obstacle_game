using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // these variables change our movement speed
    //[SerializeField] float xValue = 0f;
    //[SerializeField] float yValue = 0f;
    //[SerializeField] float zValue = 0f;

    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("press WASD or arrow keys to move the cube");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue,0,zValue); 
    }
}
