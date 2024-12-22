using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance_Text;
       void Start()
    {
    
    }


    void Update()
    {
        // 자동차와 깃발 사이의 거리 계산
        float length = flag.transform.position.x - car.transform.position.x;

        // 거리 텍스트 업데이트
     
        // 거리가 음수일 경우 게임 오버 메시지 출력
        if (length < 0)
        {
            distance_Text.text = "게임오버";
        }
        else
        {
            distance_Text.text = "목표 지점까지 " + length.ToString("F3") + "m";

        }

    }
}