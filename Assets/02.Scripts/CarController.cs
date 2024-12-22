using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f; // ���� �ӵ�
    public float maxSpeed = 5f; // �ִ� �ӵ�
    public float acceleration = 2f; // ���� �ӵ�
    public float deceleration = 2f; // ���� �ӵ�
    private bool isAccelerating = false; // ���� ������ Ȯ��

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư Ŭ��
        {
            isAccelerating = true; // ���� ���� Ȱ��ȭ
        }

        if (Input.GetMouseButtonUp(0)) // ���콺 ���� ��ư�� ��
        {
            isAccelerating = false; // ���� ���� ��Ȱ��ȭ
        }

        if (isAccelerating)
        {
            // ����
            speed += acceleration * Time.deltaTime;
            if (speed > maxSpeed)
                speed = maxSpeed; // �ִ� �ӵ��� �ʰ����� �ʵ��� ����
        }
        else
        {
            // ����
            speed -= deceleration * Time.deltaTime;
            if (speed < 0f)
                speed = 0f; // �ӵ��� ������ ���� �ʵ��� ����
        }

        // �ڵ����� ���������� �̵�
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}

