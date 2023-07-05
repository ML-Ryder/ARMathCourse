using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManage : MonoBehaviour
{
    bool isHasGyro = false;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        if (SystemInfo.supportsGyroscope)
        {  // 检查手机是否有提供陀螺仪功能
            Input.gyro.enabled = true;  // 启用陀螺仪
            isHasGyro = true;
        }
        else
        {
            Debug.Log("No Gyro!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0.0f ,0.0f , Input.gyro.attitude.eulerAngles.z-90f);
    }
}
