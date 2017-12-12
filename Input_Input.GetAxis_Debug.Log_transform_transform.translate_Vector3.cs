# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//https://m.blog.naver.com/ocy1011/220719994444
using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    float h, v;

    //유니티에서 흔하게 사용되는 변수는 int, float, string, bool과 Vector2, Vector3이다.
    //int는...
    //float는...
    //string는...
    //bool는...
    //Vector2는 2차원 벡터이다. Vector2 x = new Vector2(0,0);
    //Vector3는 3차원 벡터이다. Vector3 x = new Vector3(0,0,0);

    //유니티에서 게임을 실행할 때 한 번만 실행하는 함수이다.
    void Start () {
	
	}
	
	//특정한 조건이 없으면 계속 실행하는 함수이다.
	void Update ()
    {
        h = Input.GetAxis("Horizontal");    //Input.~:사용자로부터 어떠한 입력을 받는다. //Input.GetAxis():사용자로부터 축 입력을 받는다.axis는 축이다.
        v = Input.GetAxis("Vertical");  //"Horizontal":가로축,수평축이다. "Vertical"은 세로축,수직축이다. → 가로축,수평축과 세로축,수직축을 받는다.

        //방향키의 값을 받는다.
        Debug.Log("h=" + h + ",v=" + v); //Debug.Log():콘솔창에 출력하는 함수이다. //string은 큰따옴표 안에 문자를 입력해야 인식한다. //+는 다른 변수를 추가시킨다. //,는 보기 편하라고 입력했다.
        //Debug.Log(h); Debug.Log(v); //h,v변수가 float형이기 때문에, 콘솔창에 숫자만 나온다. 

        //게임재생 옆에 일시정지버튼을 누르면, 게임이 정지되고 콘솔창에 나오는 내용도 정지된다. 전에 나온 내용들을 확인하고 싶을때 정지해놓고 보는 것이 편하다.
        //콘솔창의 Clear버튼은 콘솔창의 내용을 다 지운다.

        //플레이어를 움직인다.
        //transform.Translate(new Vector3(h, 0, v));  //transform:Inspector에 있는 Transform의 정보를 받거나 변경한다. 이 스크립트가 Capsule에게 적용되어 있고 void Update(){}안에 있으니, 수시로 Capsule의 Transform의 정보를 받는다. //trnasform.Translate():Transform을 괄호 안의 방향으로 움직이게 만든다. Vector3의 좌표는 (x,y,z)순인데 X는 오른쪽 방향, y는 위 방향, z는 뒤 방향을 가리킨다.

        //이런 식으로 입력하는 것이 보기 좋다.
        Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir);
    }
}
