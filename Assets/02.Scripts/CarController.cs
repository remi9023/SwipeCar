using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f; // 현재 속도
    Vector2 startPos;
    bool isGameStart = false; // 게임 시작 여부 확인

    void Start()
    {
        GetComponent<AudioSource>().Stop(); // 씬이 로드될 때 소리 정지
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            startPos = Input.mousePosition; // 클릭했을 때 마우스 좌표
        }

        if (Input.GetMouseButtonUp(0)) // 마우스 왼쪽 버튼 뗌
        {
            Vector2 endPos = Input.mousePosition; // 마우스 뗐을 때 좌표
            float swipeLength = endPos.x - startPos.x; // 드래그한 거리
            swipeLength = Mathf.Abs(swipeLength); // 절댓값 처리
            speed = swipeLength / 1500.0f; // 스와이프 길이에 따라 속도 계산

            if (!GetComponent<AudioSource>().isPlaying && isGameStart == false) // 소리가 재생 중이 아니고 게임이 처음 시작되었을 때만
            {
                GetComponent<AudioSource>().Play(); // 효과음 재생
                isGameStart = true; // 이후부터 소리를 재생하지 않음
            }
        }

        transform.Translate(speed, 0f, 0f); // 자동차 이동
        speed *= 0.98f; // 속도 점차 감소
    }
}