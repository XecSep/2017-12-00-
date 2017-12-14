# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//transform.position
        //
        // 요약:
        //     ///
        //     The position of the transform in world space.
        //     ///
        public Vector3 position { get; set; }


using UnityEngine;
using System.Collections;

public class Player_position : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
      transform.position = new Vector3(10, 10, 10);
    }
}
