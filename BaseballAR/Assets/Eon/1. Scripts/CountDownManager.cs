using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownManager : MonoBehaviour
{
    public Text countDownText;

    public Button endingBtn;

    void Start()
    {
        StartCoroutine(ReadyToPlay());
      //  StartCoroutine(MoveToEndingScene());
    }

    IEnumerator ReadyToPlay()
    {
        endingBtn.gameObject.SetActive(false);
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
        countDownText.text = "START!";
        yield return new WaitForSeconds(1);
        countDownText.gameObject.SetActive(false);
    }
    /*
    IEnumerator MoveToEndingScene()
    {
        yield return WaitForSeconds(80);
        countDownText.gameObject.SetActive(true);
        countDownText.text = "END";
        endingBtn.gameObject.SetActive(true);
    }
    */
    public void OnClickEnding()
    {
        SceneManager.LoadScene("EndScene");
    }
}
