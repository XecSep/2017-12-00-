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
      transform.rotation = Quaternion.Lerp(transform.rotation, a.transform.rotation, 0.1f);	//Lerp(a,b,t)이다.a를 b까지 t시간만큼 비례하여 바꾼다. t는 0~1값을 입력한다.최대값1을 입력하면 a는 한번에 b가 된다.중간값0.5f를 입력하면 a는 0.5시간동안 b가 된다. 일반적으로 a = ~Lerp(a,b,t)형태로 사용한다.
    }
}
