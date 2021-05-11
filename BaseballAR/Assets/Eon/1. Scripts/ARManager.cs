using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARManager : MonoBehaviour
{
    public GameObject field;
    public GameObject testCam;
    public GameObject arSesstion;
    public GameObject arSesstionOrigin;

    public GameObject indicator;
    public GameObject stadium;
    public GameObject ui;
    //public GameObject zone;

    ARRaycastManager rayManager;
    // Start is called before the first frame update
    private void Awake()
    {
#if UNITY_EDITOR
        arSesstion.SetActive(false);
        arSesstionOrigin.SetActive(false);
        testCam.SetActive(true);
        field.SetActive(true);

#else
        arSesstion.SetActive(true);
        arSesstionOrigin.SetActive(true);
        testCam.SetActive(false);
        field.SetActive(false);
#endif
    }

    void Start()
    {
        rayManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

#if UNITY_EDITOR
        RaycastHit hit = new RaycastHit();
        int layer = 1 << LayerMask.NameToLayer("Field");
        if(Physics.Raycast(ray, out hit, 100, layer))
        {
            DetectedGround(hit.point);
        }
#else
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if(rayManager.Raycast(ray, hits, TrackableType.Planes))
        {
            DetectedGround(hits[0].pose.position);
        }
#endif
        else
        {
            indicator.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(indicator.activeSelf == true)
            {
                stadium.SetActive(true);
                stadium.transform.position = indicator.transform.position;
                stadium.transform.rotation = indicator.transform.rotation;

                //zone.SetActive(true);
                //zone.transform.position = indicator.transform.position - new Vector3(0, -0.1f, 1.8f);
                //zone.transform.rotation = indicator.transform.rotation;

                ui.SetActive(true);
                indicator.SetActive(false);
                enabled = false;
            }
        }

    }

    void DetectedGround(Vector3 hitPos)
    {
        indicator.SetActive(true);
        indicator.transform.position = hitPos;

        indicator.transform.eulerAngles = new Vector3(0, Camera.main.transform.eulerAngles.y, 0);
            
     }
}
