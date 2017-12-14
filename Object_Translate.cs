# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//transform.Translate()함수

using UnityEngine;
using System.Collections;

public class Object_Translate : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
      transform.Translate(new Vector3(0.1f, 0, 0)); //trnasform.Translate():Transform을 괄호 안의 방향으로 움직이게 만든다.
    }
}
