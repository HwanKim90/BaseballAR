using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    // �׳� �� ������� �ڵ��Ѱ��̱� ������ �������� �Ͻ÷��°Ͱ��� �� ���� �� �ֽ��ϴ�.
    // ����� �׳� �̷��� �����ϰڴٶ�� ���̴� �׳� ���������ּ���~~

    // Ÿ�̸� ���⶧���� �ð������� �� ���� �� �ִ� ����Ʈ�� ����ϴ�.
    List<float> PauseTimeList = new List<float>();
    
    // ���⿡ �ð� �����̴ϴ�.
    float time;

    void Update()
    {
        // �ð��귯����
        time = Time.time;
        
        // �Լ��� ȣ���Ұ̴ϴ�. 
        TimeStop();
        ListTime();
    }

    // ���� ���� Ÿ�̸� ��ž ����ѱ��
    void TimeStop()
    {
        // ������ ���� �ٲټ���. �ϴ� TŰ ������ Ÿ�� ���ߴ°��Դϴ�.
        if (Input.GetKeyDown(KeyCode.T))
        {
            // ����Ʈ�� �ح����� Ÿ�� �ֽ��ϴ�.
            PauseTimeList.Add(time);
            
            // �ܼ�â�� Ȯ���ҷ��� �׳� �����̴ϴ�. for�� ���Ӵٰ� ����������.
            for (int i = 0; i < PauseTimeList.Count; i++)
            {
                print(PauseTimeList[i]);
            }
        }
    }

    // ����Ʈ�� �־��� Ÿ�ӵ� �����ִ� �Լ��Դϴ�.
    void ListTime()
    {
        // Ÿ�� ������� �з����ݴϴ�. 
        PauseTimeList.Sort();

        // ���� ����Ʈ ���ٷ��� ���̴ϴ� ���� ����������.
        // RŰ ������ ���� �����ݴϴ�. ������ ���� �˾Ƽ� �ٲټ��� 
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < PauseTimeList.Count; i++)
            {
                print("���� : " + PauseTimeList[i]);
            }
        }

    }
    // ����� �ȶ��մϴ�. �ڽŰ��� ��������. 
}
