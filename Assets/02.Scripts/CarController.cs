using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f; // 현재 속도
    Vector2 startPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            startPos = Input.mousePosition; // 클릭했을 때 마우스 좌표 괄호 벗어났을 때 사라지면 안되기 때문에 제일 위에 변수를 선언함.
        }

        if (Input.GetMouseButtonUp(0)) // 마우스 왼쪽 버튼 클릭
        {
            Vector2 endPos = Input.mousePosition;   // 마우스 뗐을 때 좌표 어차피 괄호안에서만 쓸거라 날아가도 괜찮아서 괄호 안에서만 씀.
            float swipeLength = endPos.x - startPos.x; // 마우스 드래그한 거리
            swipeLength = Mathf.Abs(swipeLength);
            speed = swipeLength/1500.0f; // 스와이프 길이의 속도를 변경해줌 (1500분의 거리로 비율 조정)    
        }


        transform.Translate(speed, 0f, 0f);
        speed *= 0.98f;
    }
}

