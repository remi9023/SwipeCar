using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0f; // ���� �ӵ�
    Vector2 startPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư Ŭ��
        {
            startPos = Input.mousePosition; // Ŭ������ �� ���콺 ��ǥ ��ȣ ����� �� ������� �ȵǱ� ������ ���� ���� ������ ������.
        }

        if (Input.GetMouseButtonUp(0)) // ���콺 ���� ��ư Ŭ��
        {
            Vector2 endPos = Input.mousePosition;   // ���콺 ���� �� ��ǥ ������ ��ȣ�ȿ����� ���Ŷ� ���ư��� �����Ƽ� ��ȣ �ȿ����� ��.
            float swipeLength = endPos.x - startPos.x; // ���콺 �巡���� �Ÿ�
            swipeLength = Mathf.Abs(swipeLength);
            speed = swipeLength/1500.0f; // �������� ������ �ӵ��� �������� (1500���� �Ÿ��� ���� ����)    
        }


        transform.Translate(speed, 0f, 0f);
        speed *= 0.98f;
    }
}

