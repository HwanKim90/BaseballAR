using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrikeZoneHelper : MonoBehaviour
{
    public GameObject strikeZone;
    
    public Material green;
    
    public static bool isStrike;
    int ballCnt;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Test();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //ballCnt = Random.Range(1, 46);
        if (other.CompareTag("Ball"))
        {
            isStrike = false;
//            print("º¼ Ãæµ¹!!");
            Hitting.stayTime = 0;
            strikeZone.SetActive(true);
            ballCnt++;
            //other.GetComponentInChildren<Text>().text = ballCnt.ToString();
            if (isStrike == false) other.GetComponent<MeshRenderer>().material = green;
            Destroy(other.gameObject, 2f);

        }
    }
     
    void Test()
    {
        Renderer rd = strikeZone.GetComponent<Renderer>();
        rd.material.shader = Shader.Find("DissolveEftShader");
        print(rd.material.shader);
    }

     
    
}
