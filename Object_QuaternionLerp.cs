# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//Quaternion.Lerp()

using UnityEngine;
using System.Collections;

public class Object_QuaternionLerp : MonoBehaviour {

    public GameObject a;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
      transform.rotation = Quaternion.Lerp(transform.rotation, a.transform.rotation, 0.1f);
    }
}
