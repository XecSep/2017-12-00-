# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//Vector3.Distance()

//https://docs.unity3d.com/kr/current/ScriptReference/Vector3.Distance.html
using UnityEngine;
using System.Collections;

public class Object_Distance : MonoBehaviour {

    public Transform other;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
      if (other)
      {
        float dist = Vector3.Distance(other.position, transform.position);  //Vector3.Distance(a,b)이다.a와 b사이의 거리를 반환한다.
        Debug.Log("Distance to other" + dist);
      }
    }
}
