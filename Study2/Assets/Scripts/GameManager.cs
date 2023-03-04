using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI ���� ���̺귯��
using UnityEngine.SceneManagement; //�� �������� ���̺귯��
public class GameManager : MonoBehaviour
{
    //���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public GameObject gameoverText;
    //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text timeText;
    //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;

    private float survieTime; //�����ð�
    private bool isGameOver; //���ӿ��� ����


    void Start()
    {
        //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        survieTime = 0;
        isGameOver = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            //���� �ð� ����
            survieTime += Time.deltaTime;
            //������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time : " + (int)survieTime;
        }
        else
        {
            //���ӿ��� ���¿��� RŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                //SampleScene ���� �ε�
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    
    public void EndGame()
    {
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameOver = true;
        //���ӿ��� �ؽ�Ʈ ���� ���� ��Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);

        //BestTime Ű�� ������ ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (survieTime > bestTime)
        {
            //�ְ� ��� ���� ���� ���� �ð� ������ ����
            bestTime = survieTime;
            //����� �ְ� ����� BestTimeŰ�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        //�ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        recordText.text = "Best Time: " + (int)bestTime;
    }
}
