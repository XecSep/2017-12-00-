# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

/*
 * 마우스클릭한 곳으로 순간이동한다.
 */


 using UnityEngine;
 using System.Collections;
 public class targetmove : MonoBehaviour
 {
     Vector3 newPosition;
     void Start () {
         newPosition = transform.position;
     }
     void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out hit))
             {
                 newPosition = hit.point;
                 transform.position = newPosition;
             }
         }
     }
 }
