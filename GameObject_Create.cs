# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//게임오브젝트를 만든다.

using UnityEngine;
using System.Collections;

public class GameObject_Create : MonoBehaviour {

	// Use this for initialization
	void Start ()
    	{
        	GameObject Player;
        	Player = new GameObject("Player");
	}
	
	// Update is called once per frame
	void Update ()
    	{
    
    	}
}
