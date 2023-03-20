using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;


    // Start is called before the first frame update
    void Start()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetButtonDown("CamKey1"))
        {
            CameraView1();
        }

        if (Input.GetButtonDown("CamKey2"))
        {
            CameraView2();
        }

        if (Input.GetButtonDown("CamKey3"))
        {
            CameraView3();
        }
    }

    public void CameraView1()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
    }

    public void CameraView2()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(true);
        Cam3.SetActive(false);
    }

    public void CameraView3()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(true);
    }

}
