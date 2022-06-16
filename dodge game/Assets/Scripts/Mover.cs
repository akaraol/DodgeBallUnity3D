using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    

   [SerializeField] float moveSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        PrintHowToPlay();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void PrintHowToPlay(){

        Debug.Log("Wellcome");
        Debug.Log("Use WASD to move our little buddy Kuros");
        Debug.Log("And do not hit the walls!");

    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        transform.Translate(xValue, 0 ,zValue);
    }

}
