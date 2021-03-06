using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    // 그냥 제 생각대로 코딩한거이기 때문에 수연님이 하시려는것과는 안 맞을 수 있습니다.
    // 저라면 그냥 이렇게 구현하겠다라는 것이니 그냥 참조만해주세요~~

    // 타이머 멈출때마다 시간저장한 거 넣을 수 있는 리스트를 만듭니다.
    List<float> PauseTimeList = new List<float>();
    
    // 여기에 시간 넣을겁니다.
    float time;

    void Update()
    {
        // 시간흘러가요
        time = Time.time;
        
        // 함수를 호출할겁니다. 
        TimeStop();
        ListTime();
    }

    // 님이 만든 타이머 스탑 비슷한기능
    void TimeStop()
    {
        // 조건은 님이 바꾸세요. 일단 T키 누르면 타임 멈추는거입니다.
        if (Input.GetKeyDown(KeyCode.T))
        {
            // 리스트에 멈췃을때 타임 넣습니다.
            PauseTimeList.Add(time);
            
            // 콘솔창에 확인할려고 그냥 넣은겁니다. for문 나왓다고 쫄지마세요.
            for (int i = 0; i < PauseTimeList.Count; i++)
            {
                print(PauseTimeList[i]);
            }
        }
    }

    // 리스트에 넣어준 타임들 보여주는 함수입니다.
    void ListTime()
    {
        // 타임 순서대로 분류해줍니다. 
        PauseTimeList.Sort();

        // 순서 프린트 해줄려고 쓴겁니다 역시 쫄지마세요.
        // R키 누르면 순위 보여줍니다. 조건은 님이 알아서 바꾸세요 
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < PauseTimeList.Count; i++)
            {
                print("순위 : " + PauseTimeList[i]);
            }
        }

    }
    // 당신은 똑똑합니다. 자신감을 가지세요. 
}
