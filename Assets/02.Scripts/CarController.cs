using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f; // ���� �ӵ�
    Vector2 startPos;
    bool isGameStart = false; // ���� ���� ���� Ȯ��

    void Start()
    {
        GetComponent<AudioSource>().Stop(); // ���� �ε�� �� �Ҹ� ����
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư Ŭ��
        {
            startPos = Input.mousePosition; // Ŭ������ �� ���콺 ��ǥ
        }

        if (Input.GetMouseButtonUp(0)) // ���콺 ���� ��ư ��
        {
            Vector2 endPos = Input.mousePosition; // ���콺 ���� �� ��ǥ
            float swipeLength = endPos.x - startPos.x; // �巡���� �Ÿ�
            swipeLength = Mathf.Abs(swipeLength); // ���� ó��
            speed = swipeLength / 1500.0f; // �������� ���̿� ���� �ӵ� ���

            if (!GetComponent<AudioSource>().isPlaying && isGameStart == false) // �Ҹ��� ��� ���� �ƴϰ� ������ ó�� ���۵Ǿ��� ����
            {
                GetComponent<AudioSource>().Play(); // ȿ���� ���
                isGameStart = true; // ���ĺ��� �Ҹ��� ������� ����
            }
        }

        transform.Translate(speed, 0f, 0f); // �ڵ��� �̵�
        speed *= 0.98f; // �ӵ� ���� ����
    }
}