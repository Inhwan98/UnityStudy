using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI 관련 라이브러리
using UnityEngine.SceneManagement; //씬 관리관련 라이브러리
public class GameManager : MonoBehaviour
{
    //게임오버 시 활성화할 텍스트 게임 오브젝트
    public GameObject gameoverText;
    //생존 시간을 표시할 텍스트 컴포넌트
    public Text timeText;
    //최고 기록을 표시할 텍스트 컴포넌트
    public Text recordText;

    private float survieTime; //생존시간
    private bool isGameOver; //게임오버 상태


    void Start()
    {
        //생존 시간과 게임오버 상태 초기화
        survieTime = 0;
        isGameOver = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            //생존 시간 갱신
            survieTime += Time.deltaTime;
            //갱신한 생존 시간을 timeText 텍스트 컴포넌트를 이용해 표시
            timeText.text = "Time : " + (int)survieTime;
        }
        else
        {
            //게임오버 상태에서 R키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                //SampleScene 씬을 로드
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    
    public void EndGame()
    {
        //현재 상태를 게임오버 상태로 전환
        isGameOver = true;
        //게임오버 텍스트 게임 오브 젝트를 활성화
        gameoverText.SetActive(true);

        //BestTime 키로 지정된 이전까지의 최고 기록 가져오기
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if (survieTime > bestTime)
        {
            //최고 기록 값을 현재 생존 시간 값으로 변경
            bestTime = survieTime;
            //변경된 최고 기록을 BestTime키로 저장
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        //최고 기록을 recordText 텍스트 컴포넌트를 이용해 표시
        recordText.text = "Best Time: " + (int)bestTime;
    }
}
