using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotate : MonoBehaviour
{
    // Start is called before the first frame update

    float degree = 0.0f;
  



    // Update is called once per frame
    void Update()
    {
        degree += Time.deltaTime;
        if( degree >= 360)
        {
            degree = 0.0f;
        }
        RenderSettings.skybox.SetFloat("_Rotation", degree);
    }
}
