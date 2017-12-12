# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//↔회전한다. ↕움직인다.

using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;


    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        float translation = Input.GetAxis("Vertical") * speed;  //translation 이동
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed; //rotation 회전

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);	//Translate: Position(위치)을 조작한다.
        transform.Rotate(0, rotation, 0);	//Rotate: Rotation(회전)을 조작한다.
    }
}
