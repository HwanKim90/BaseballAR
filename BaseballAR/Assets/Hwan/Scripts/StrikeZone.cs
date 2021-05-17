using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeZone : MonoBehaviour
{
    public static StrikeZone instance;
    public static bool isPitching;
    public static float dissolve;
    
    public Material yellow;
    Material dissolveMat;
    string dissolveName;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        dissolveMat = GetComponent<MeshRenderer>().material;
        dissolveName = dissolveMat.shader.GetPropertyName(3);
    }

    private void Update()
    {
        if (isPitching)
        {
            print("피칭");
            SetShaderPropertyValue();
        }
        
            
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("Ball"))
        {
            StrikeZoneHelper.isStrike = true;
            other.GetComponent<MeshRenderer>().material = yellow;
        }
    }

    // 시간에 따라 움직이게 어케하냐 아.. 업데이트에서 해야되는데
    public void SetShaderPropertyValue()
    {
        if (dissolve < 1 && isPitching) dissolve += 0.031f;
        //if (dissolve > 0 && !isPitching) dissolve -= 0.05f;

        dissolveMat.SetFloat(dissolveName, dissolve);
    }
}
    