# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

/*
 * 구분선이다. 마우스 클릭한 곳으로 객체가 이동한다.
 */

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
 public float _velocity = 10.0f;
 public LayerMask _layer;

 private CharacterController _controller;
 private bool _isMove = false;
 private Vector3 _destination = new Vector3(0, 0, 0);

 void Start () {
  _controller = gameObject.GetComponent<CharacterController>();
  _isMove = false;
 }

 

 void Update () {
  //화면을 클릭 하면 땅바닥 좌표 저장.
  if (Input.GetMouseButton(0)) {
   Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   RaycastHit hit;   
 
   if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layer)) {
    _destination = hit.point;
    _isMove = true;
   }
  }
 
  //땅바닥 좌표가 플레이어와 다르면 움직인다.
  if (_isMove)
  {
   Move();
  }
 }

 //움직이는 함수
 private void Move() {
  //목적지와 거리가 같으면 안 움직임
  if (Vector3.Distance(transform.position, _destination) == 0.0F) {
   _isMove = false;
   return;
  }
 
  Vector3 direction = _destination - transform.position;
  direction = Vector3.Normalize(direction);
 
  _controller.Move(direction * Time.deltaTime * _velocity);
 }

}


출처: http://mystorywish.tistory.com/entry/마우스-클릭한-곳으로-객체-이동 [노래를 부르며, 이렇게 조그만 미소를 지으며...^^]
