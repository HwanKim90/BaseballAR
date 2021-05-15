using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownManager : MonoBehaviour
{
    public Text countDownText;

    void Start()
    {
        StartCoroutine(ReadyToPlay());
    }

    void Update()
    {
        
    }

    IEnumerator ReadyToPlay()
    {
        countDownText.text = "��Ȯ�� Ÿ�ֿ̹� ���� ���߼���!";
        yield return new WaitForSeconds(3);
        countDownText.text = "1�� ���� ���� ���� ������ ����غ�����!";
        yield return new WaitForSeconds(3);
        countDownText.text = "���� �� �ڽ� �������� Ÿ���� ��������!";
        yield return new WaitForSeconds(3);
        countDownText.text = "���ʽ� ������ �־����ϴ�!";
        yield return new WaitForSeconds(3);
        countDownText.text = "�غ��ϼ���!";
        yield return new WaitForSeconds(4);
        countDownText.fontSize = 300;
        countDownText.text = "" + 3;
        yield return new WaitForSeconds(1);
        countDownText.text = "" + 2;
        yield return new WaitForSeconds(1);
        countDownText.text = "" + 1;
        yield return new WaitForSeconds(1);
        countDownText.text = "Start!";
        yield return new WaitForSeconds(1);
        countDownText.gameObject.SetActive(false);
    }
}
