# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

using UnityEngine;
using System.Collections;

public class Vector3_position : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Vector3 dir = new Vector3(1, 1, 1);
        transform.position = dir;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
