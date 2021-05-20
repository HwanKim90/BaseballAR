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
            print("ÇÇÄª");
            SetShaderPropertyValue();
        }   
        else
        {
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

    
    public void SetShaderPropertyValue()
    {
        dissolve = Mathf.Clamp(dissolve, 0.05f, 1f);
        if (isPitching) dissolve += 0.03f;
        if (!isPitching) dissolve -= 0.05f;

        dissolveMat.SetFloat(dissolveName, dissolve);
    }
}
    