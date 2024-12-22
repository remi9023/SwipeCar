using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f; // 현재 속도
    public float maxSpeed = 5f; // 최대 속도
    public float acceleration = 2f; // 가속 속도
    public float deceleration = 2f; // 감속 속도
    private bool isAccelerating = false; // 가속 중인지 확인

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            isAccelerating = true; // 가속 상태 활성화
        }

        if (Input.GetMouseButtonUp(0)) // 마우스 왼쪽 버튼을 뗌
        {
            isAccelerating = false; // 가속 상태 비활성화
        }

        if (isAccelerating)
        {
            // 가속
            speed += acceleration * Time.deltaTime;
            if (speed > maxSpeed)
                speed = maxSpeed; // 최대 속도를 초과하지 않도록 제한
        }
        else
        {
            // 감속
            speed -= deceleration * Time.deltaTime;
            if (speed < 0f)
                speed = 0f; // 속도가 음수가 되지 않도록 설정
        }

        // 자동차를 오른쪽으로 이동
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}

