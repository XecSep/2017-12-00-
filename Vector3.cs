# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

using UnityEngine;
using System.Collections;

public class Vector3 : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Vector3.zero:" + Vector3.zero);  //(0,0,0)
        Debug.Log("Vector3.right:" + Vector3.right);    //(1,0,0)
        Debug.Log("Vector3.up:" + Vector3.up);  //(0,1,0)
        Debug.Log("Vector3.forward:" + Vector3.forward);    //(0,0,1)
        Debug.Log("Vector3.left:" + Vector3.left);  //(-1,0,0)
        Debug.Log("Vector3.down:" + Vector3.down);  //(0,-1,0)
        Debug.Log("Vector3.back:" + Vector3.back);  //(0,0,-1)
        Debug.Log("Vector3.one:" + Vector3.one);    //(1,1,1)
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
