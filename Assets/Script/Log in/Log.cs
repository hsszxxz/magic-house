using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    public GameObject Bg , Bg2;
    public GameObject Bg3;
    public void OnLoginButtonClick()
    {
        Bg.SetActive(false);
        Bg2.SetActive(true);
        Time.timeScale = 1;
        Bg3.GetComponent<ChargeButton>().flag = true;
    }
   
    
}
