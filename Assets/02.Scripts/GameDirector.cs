using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car; // �ڵ��� ������Ʈ
    public GameObject flag; // ��� ������Ʈ
    public Text distance_Text; // �Ÿ� �ؽ�Ʈ
    public GameObject restartButton; // ����� ��ư ������Ʈ

    private bool isGameOver = false; // ���� ���� ���� Ȯ��

    void Start()
    {
  
    }

    void Update()
    {
        if (isGameOver) return; // ���� ���� ���¶�� �� �̻� Update ���� �� ��

        // �ڵ����� ��� ������ �Ÿ� ���
        float length = flag.transform.position.x - car.transform.position.x;

        if (length < 0) // ���� ���� ����
        {
            distance_Text.text = "���ӿ���";
            isGameOver = true; // ���� ���� ���� ����
            restartButton.SetActive(true); // ����� ��ư Ȱ��ȭ
        }
        else
        {
            distance_Text.text = "��ǥ �������� " + length.ToString("F3") + "m";
        }
    }

    // ����� ��ư�� ����� �Լ�
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���� �� �����
    }
}