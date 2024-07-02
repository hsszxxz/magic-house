using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChargeButton : MonoBehaviour
{
    private GameObject Star;
    private StarsNumber starScript;
    private Button YiMuCaoKeLi;
    private Button BuLuoFen;
    private Button WeiShengMianTiao;
    private Image YiMuCaoKeLiimg;
    private Text YiMuCaoKeLitext;
    private Image BuLuoFenimg;
    private Text BuLuoFentext;
    private Image WeiShengMianTiaoimg;
    private Text WeiShengMianTiaotext;
    public GameObject[] Note;
    public GameObject Video;
    public bool flag=true;
    private void Start()
    {
        Star = GameObject.Find("Stars");
        starScript = Star.GetComponent<StarsNumber>();
        YiMuCaoKeLi = GameObject.Find("YiMuCaoKeLi").GetComponent<Button>();
        YiMuCaoKeLiimg = GameObject.Find("YiMuCaoKeLi").GetComponent<Image>();
        YiMuCaoKeLitext = GameObject.Find("YiMuCaoKeLi").GetComponentInChildren<Text>();
        BuLuoFen = GameObject.Find("BuLuoFen").GetComponent<Button>(); 
        WeiShengMianTiao = GameObject.Find("WeiShengMianTiao").GetComponent<Button>();
        BuLuoFenimg = GameObject.Find("BuLuoFen").GetComponent<Image>();
        BuLuoFentext = GameObject.Find("BuLuoFen").GetComponentInChildren<Text>();
        WeiShengMianTiaoimg = GameObject.Find("WeiShengMianTiao").GetComponent<Image>();
        WeiShengMianTiaotext = GameObject.Find("WeiShengMianTiao").GetComponentInChildren<Text>();
    }
    private void Update()
    {
        if (starScript.starsNumber >= 300)
        {
            Video.SetActive(true);
        }
         if (starScript.starsNumber  >= 200 &&flag)
        {
            WeiShengMianTiao.interactable = true;
            WeiShengMianTiaoimg.raycastTarget = true;
            WeiShengMianTiaotext.raycastTarget = true;
            Note[2].SetActive(true);
            Time.timeScale = 0;
            flag = false;
        }
        else if (starScript.starsNumber >= 100 && flag)
        {
            BuLuoFen.interactable=true;
            BuLuoFenimg.raycastTarget = true;
            BuLuoFentext.raycastTarget = true;
            Note[1].SetActive(true);
            Time.timeScale = 0;
            flag = false;
        }
        else if (starScript.starsNumber >= 50 && flag)
        {
            YiMuCaoKeLi.interactable = true;
            YiMuCaoKeLiimg.raycastTarget = true;
            YiMuCaoKeLitext.raycastTarget = true;
            Note[0].SetActive(true);
            Time.timeScale = 0;
            flag = false;
        }
    }
}
