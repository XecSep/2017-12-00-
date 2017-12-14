# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//Input.GetAxisRaw(), Vector3, Time.deltaTime, transform.Translate()

using UnityEngine;
using System.Collections;

public class Vector3 : MonoBehaviour {

    float h, v;
    int moveSpeed = 5; 

    // Use this for initialization
    void Start ()
    {
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v) * moveSpeed * Time.deltaTime;  //↔ 누르면 x축으로 이동하고, ↕ 누르면 z축으로 이동한다.
        transform.Translate(dir);
    }
}
