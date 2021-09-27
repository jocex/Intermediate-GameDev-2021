using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed =2.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);

    }

    void MoveObject(){
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate((Vector2.right *Time.deltaTime)*speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate((Vector2.left *Time.deltaTime)*speed);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate((Vector2.down *Time.deltaTime)*speed);
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate((Vector2.up *Time.deltaTime)*speed);
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveObject();
        if (transform.position.y > 3){
            transform.position = new Vector3(transform.position.x,3,0);
        }
        if (transform.position.y < -3){
            transform.position = new Vector3(transform.position.x,-3,0);

        }
        if (transform.position.x < -7){
            transform.position = new Vector3(-7,transform.position.y,0);
        }
        if (transform.position.x > 7){
            transform.position = new Vector3(7,transform.position.y,0);
        }
        }
    }

