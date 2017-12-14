# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//Vector3.Lerp()

//https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
using UnityEngine;
using System.Collections;

    public Transform startMarker;
    public Transform endMarker;

    public float speed = 1.0f;

    private float starTime;
    private float journeyLength;

public class Object_VectorLerp : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
       starTime = Time.time;
       journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
	
	// Update is called once per frame
	void Update ()
    {
      float distCovered = (Time.time - starTime);
      float fracJourney = distCovered / journeyLength;

      transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney); //Lerp(a,b,t)이다.a를 b까지 t시간만큼 비례하여 바꾼다. t는 0~1값을 입력한다.최대값1을 입력하면 a는 한번에 b가 된다.중간값0.5f를 입력하면 a는 0.5시간동안 b가 된다. 일반적으로 a = ~Lerp(a,b,t)형태로 사용한다.
    }
}
