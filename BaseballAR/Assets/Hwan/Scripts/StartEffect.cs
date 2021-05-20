using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEffect : MonoBehaviour
{
    Material startEft;
    string dissolveName;
    float dissolve;

    void Start()
    {
        startEft = GetComponent<MeshRenderer>().material;
        dissolveName = startEft.shader.GetPropertyName(3);
        print(startEft.name);
        
    }

    
    void Update()
    {
        if (dissolve <= 1)
        {
            dissolve += 0.3f * Time.deltaTime;
        }
        startEft.SetFloat(dissolveName, dissolve);
    }
}
