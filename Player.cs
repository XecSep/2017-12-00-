# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

//사용한 함수들 목록이다.
//Input, Input.GetAxis, Debug.Log, transform, transform.Translate, Vector3, Time.deltaTIme, Input.GetAxisRaw, Input.GetKey, Input.GetKeyDown, Input.GetKeyUp, KeyCode.~, KeyCode.~Arrow, KeyCode.Keypad~
	
//https://m.blog.naver.com/ocy1011/220719994444 //https://m.blog.naver.com/ocy1011/220720464523
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    float h, v; //가로축 입력값 변수이다. //세로축 입력값 변수이다.
    int moveSpeed = 5;  //이동속도 변수이다. //초기화를 해주지 않으면 int moveSpeed=0인 상태이기 때문에, 이동속도가 0이라 움직이지 않는다.

    //유니티에서 흔하게 사용되는 변수는 int, float, string, bool과 Vector2, Vector3이다.
    //int는...
    //float는...
    //string는...
    //bool는...
    //Vector2는 2차원 벡터이다. Vector2 x = new Vector2(0,0);
    //Vector3는 3차원 벡터이다. Vector3 x = new Vector3(0,0,0);

    //유니티에서 게임을 실행할 때 한 번만 실행하는 함수이다.
    // Use this for initialization 
    void Start () {
	
	}

    //특정한 조건이 없으면 계속 실행하는 함수이다.
    // Update is called once per frame
    void Update ()
    {
        /*
        //GetAxis는 방향키를 누르는 정도에 따라 값이 서서히 증가한다.
        h = Input.GetAxis("Horizontal");    //Input.~:사용자로부터 어떠한 입력을 받는다. //Input.GetAxis():사용자로부터 축 입력을 받는다.axis는 축이다.
        v = Input.GetAxis("Vertical");  //"Horizontal":가로축,수평축이다. "Vertical"은 세로축,수직축이다. → 가로축,수평축과 세로축,수직축을 받는다.

        //방향키의 값을 받는다.
        Debug.Log("h=" + h + ",v=" + v); //Debug.Log():콘솔창에 출력하는 함수이다. //string은 큰따옴표 안에 문자를 입력해야 인식한다. //+는 다른 변수를 추가시킨다. //,는 보기 편하라고 입력했다.
        //Debug.Log(h); Debug.Log(v); //h,v변수가 float형이기 때문에, 콘솔창에 숫자만 나온다. 
        */

        /*
        //플레이어를 움직인다.
        transform.Translate(new Vector3(h, 0, v));  //transform:Inspector에 있는 Transform의 정보를 받거나 변경한다. 이 스크립트가 Capsule에게 적용되어 있고 void Update(){}안에 있으니, 수시로 Capsule의 Transform의 정보를 받는다. //trnasform.Translate():Transform을 괄호 안의 방향으로 움직이게 만든다. Vector3의 좌표는 (x,y,z)순인데 X는 오른쪽 방향, y는 위 방향, z는 뒤 방향을 가리킨다.
        */

        /*
        //이런 식으로 입력하는 것이 보기 좋다.
        Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir);
        */

        /*
        //오브젝트의 속도를 조절한다.
        Vector3 dir = new Vector3(h, 0, v) * moveSpeed; //Vector에 숫자를 곱하는 경우, Vector의 x,y,z 값 각각에 숫자가 곱해진다. new Vector3(h, 0, v) * moveSpeed는 new Vector3(h * moveSpeed, 0 * moveSpeed, v * moveSpeed)와 같다.
        transform.Translate(dir);
        */

        /*
        //다른 방법으로 Vector3 dir = new Vector3(h, 0, v); dir *= moveSpeed;로 쓰는 법이 있다.
        Vector3 dir = new Vector3(h, 0, v); 
        dir *= moveSpeed; //dir *= moveSpeed는 dir = dir * moveSpeed와 같다. //더하기,빼기,나누기,나머지와 사용이 가능하다. x += 5, x -= 5, x /= 5, x %= 5. 이렇게 쓰면 코드가 조금 더 짧아지고 타자치는 수고를 줄인다.
        transform.Translate(dir);
        */

        /*
        Vector3 dir = new Vector3(h, 0, v) * moveSpeed; //움직이면서 Capsule의 Transform을 확인하면, Position이 순식간에 0과 100사이를 오고 간다. // Update is called once per frame //void Update(){}함수는 시간 단위의 1초,2초가 아닌, 게임 상의 frame당(마다) Update 안의 내용을 실행시킨다. 즉, 1초마다 new Vector3(h, 0, v) * moveSpeed의 좌표를 움직이는게 아니라, frame마다 new Vector3(h, 0, v) * moveSpeed의 좌표를 움직인다.
        transform.Translate(dir);
        */

        /*
        //frame에 맞는 이동속도로 바꾼다.
        Vector3 dir = new Vector3(h, 0, v) * moveSpeed * Time.deltaTime;    //Vector3 dir = new Vector3(h, 0, v) * moveSpeed 뒤에 * Time.deltaTime를 추가했다. //Time.deltaTime은 frame의 단위 시간이다. frame은 절대적이지 않고, 컴퓨터나 모바일기기의 성능,사양에 따라 달라지는 상대적이다. 게임 내 FPS:~라는 것을 보았다. Frame Per Second 약자로 초당 몇 frame인지 알려준다. 고사양게임을 고사양기기로 플레이하면 FPS는 높고, 고사양게임을 저사양기기로 플레이하면 FPS는 낮고 게임도 버벅거린다. 
        transform.Translate(dir);

        Debug.Log("Time.deltaTime=" + Time.deltaTime);   //값이 얼마나 작은지 확인한다. 0.016XXX~0.017XXX.
        */

        /*
        //방향키를 누를때마다 일정한 속도를 출력한다. //GetAxisRaw는 방향키는 누르는 순간 -1,1이 된다.  //GetAxis가 GetAxisRaw보다 세밀하다.
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        */

        /*
        //특정한 키를 입력 받으면 이동속도가 달라진다.
        //Input:입력 받는다. //Input.GetKey~():키보드 키를 입력 받는다. //Input.GetKey~()는 세가지 종류가 있다. 1.Input.GetKey(KeyCode.Z):Z키를 누르고 있는 동안 계속 입력 받는다. 2.Input.GetKeyDown(KeyCode.Z):Z키가 눌러질 때(내려갈 때) 한 번 입력 받는다. 3.Input.GetKeyUp(KeyCode.Z):Z키가 눌러졌다 뗄 때(올라갈 때) 한 번 입력 받는다. //GetKey 뒤에 아무것도 없으면 누르고 있을 때, GetKey 뒤에 Down이 있으면 내려갈 때, GetKey 뒤에 Up이 있으면 올라갈 때, 글자 그대로 생각하면 이해하기 쉽다. 
        if (Input.GetKeyDown(KeyCode.Z))    //KeyCode.~:키보드 키이다. //방향키는 KeyCode.UpArrow,KeyCode.DownArrow,KeyCode.RightArrow,KeyCode.LeftArrow가 있다. //키패드는 KeyCode.Keypad0,KeyCode.Keypad1,KeyCode.Keypad2,...,KeyCode.Keypad9가 있다. //그 외 여러가지를 받을 수 있다.
            moveSpeed = 1;  //Z를 입력하면 이동속도가 1이 된다. 
        if (Input.GetKeyDown(KeyCode.X))    
            moveSpeed = 5;  //X를 입력하면 이동속도가 5이 된다.
        if (Input.GetKeyDown(KeyCode.C))    
            moveSpeed = 10; //C를 입력하면 이동속도가 10이 된다.
        //dir에 moveSpeed가 곱해지는데, moveSpeed값이 바뀌니깐 frame당 이동거리가 달라진다.

        Debug.Log("moveSpeed=" + moveSpeed);
        */

        //코드를 정리한다.
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //Debug.Log("h=" + h + ",v=" + v);

        if (Input.GetKeyDown(KeyCode.Z))    
            moveSpeed = 1;  
        if (Input.GetKeyDown(KeyCode.X))
            moveSpeed = 5;  
        if (Input.GetKeyDown(KeyCode.C))
            moveSpeed = 10;

        Debug.Log("moveSpeed=" + moveSpeed);

        Vector3 dir = new Vector3(h, 0, v) * moveSpeed * Time.deltaTime;
        transform.Translate(dir);
    }
}
