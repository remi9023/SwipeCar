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
        // �ڵ����� ��� ������ �Ÿ� ���
        float length = flag.transform.position.x - car.transform.position.x;

        // �Ÿ� �ؽ�Ʈ ������Ʈ
     
        // �Ÿ��� ������ ��� ���� ���� �޽��� ���
        if (length < 0)
        {
            distance_Text.text = "���ӿ���";
        }
        else
        {
            distance_Text.text = "��ǥ �������� " + length.ToString("F3") + "m";

        }

    }
}