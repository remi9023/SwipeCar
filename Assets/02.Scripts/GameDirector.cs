using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance_Text;
    public GameObject restart_Button;
    bool GameObject  = false;
       void Start()
    {
        restart_Button.SetActive(false);
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
            restart_Button.SetActive(true); 
        }
        else
        {
            distance_Text.text = "��ǥ �������� " + length.ToString("F3") + "m";

        }

    }
}