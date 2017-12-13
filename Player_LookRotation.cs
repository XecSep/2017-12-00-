# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//Quaternion.LookRotation():괄호 안의 방향으로 쳐다보게 만든다.

using UnityEngine;
using System.Collections;

public class Player_LookRotation : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward);  //오브젝트가 앞을 쳐다본다.
        transform.rotation = Quaternion.LookRotation(Vector3.back); //오브젝트가 뒤를 쳐다본다.
        transform.rotation = Quaternion.LookRotation(Vector3.left); //오브젝트가 왼쪽을 쳐다본다.
        transform.rotation = Quaternion.LookRotation(Vector3.right);    //오브젝트가 오른쪽을 쳐다본다.
        transform.rotation = Quaternion.LookRotation(Vector3.up);   //오브젝트가 위를 쳐다본다.
        transform.rotation = Quaternion.LookRotation(Vector3.down); //오브젝트가 아래를 쳐다본다.
    }
}
