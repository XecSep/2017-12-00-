# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//transform.position, transform.rotation, transform.localScale

using UnityEngine;
using System.Collections;

public class Player_BasicTransform. : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
      transform.position = new Vector3(1, 1, 1);
      transform.rotation = Quaternion.LookRotation(Vector3.back);
      transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
