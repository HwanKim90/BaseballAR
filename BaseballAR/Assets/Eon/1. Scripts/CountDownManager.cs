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
        countDownText.text = "정확한 타이밍에 공을 맞추세요!";
        yield return new WaitForSeconds(3);
        countDownText.text = "1분 동안 가장 높은 점수를 기록해보세요!";
        yield return new WaitForSeconds(3);
        countDownText.text = "담장 앞 박스 방향으로 타구를 보내세요!";
        yield return new WaitForSeconds(3);
        countDownText.text = "보너스 점수가 주어집니다!";
        yield return new WaitForSeconds(3);
        countDownText.text = "준비하세요!";
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
