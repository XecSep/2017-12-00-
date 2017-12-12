# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

/*
 * 구분선이다. 마우스 클릭한 곳의 좌표를 구한다.
 */

using UnityEngine;
using System.Collections;
 
public class ScreenRay : MonoBehaviour {
 
    public int clickLayer = 8;
    public int blockLayer = 9;
     
    // Update is called once per frame
    void Update () {
     
        if (Input.GetMouseButtonUp (0))
        {
            Debug.Log("hit !!");
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
 
            RaycastHit hitInfo;
 
            if( Physics.Raycast(ray,out hitInfo, 100f) )
            {
                Debug.Log("hit point : " + hitInfo.point);
 
                int l = hitInfo.transform.gameObject.layer;
 
                if( l == clickLayer )
                {
                    Debug.Log(" hit object : " + hitInfo.collider.name);
                }
                  
            }
        }
 
    }
}


출처: http://cosmostudio.tistory.com/entry/RayCast로-클릭한-곳의-좌표-구하기?category=577593 [Cosmo Studio]
