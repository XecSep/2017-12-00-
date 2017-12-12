# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//게임오브젝트를 만들고, 컴포넌트를 삽입한다.

using UnityEngine;
using System.Collections;
 
public class Test : MonoBehaviour {
 
    // Use this for initialization
    void Start ()
    {
	//게임오브젝트를 만든다
        GameObject Player;	
        Player = new GameObject("Player");
	    
	//컴포넌트를 삽입한다.
        Player.AddComponent<MeshFilter>();	
        Player.AddComponent<BoxCollider>();
        Player.AddComponent<MeshRenderer>();
    }
    
    // Update is called once per frame
    void Update ()
    {
        
    }
}

