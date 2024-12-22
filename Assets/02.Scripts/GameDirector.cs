using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car; // 자동차 오브젝트
    public GameObject flag; // 깃발 오브젝트
    public Text distance_Text; // 거리 텍스트
    public GameObject restartButton; // 재시작 버튼 오브젝트

    private bool isGameOver = false; // 게임 오버 상태 확인

    void Start()
    {
  
    }

    void Update()
    {
        if (isGameOver) return; // 게임 오버 상태라면 더 이상 Update 실행 안 함

        // 자동차와 깃발 사이의 거리 계산
        float length = flag.transform.position.x - car.transform.position.x;

        if (length < 0) // 게임 오버 조건
        {
            distance_Text.text = "게임오버";
            isGameOver = true; // 게임 오버 상태 설정
            restartButton.SetActive(true); // 재시작 버튼 활성화
        }
        else
        {
            distance_Text.text = "목표 지점까지 " + length.ToString("F3") + "m";
        }
    }

    // 재시작 버튼에 연결될 함수
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 재시작
    }
}