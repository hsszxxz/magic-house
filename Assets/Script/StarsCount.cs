using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Character;
using UnityEngine.UI;
public class StarsCount : MonoBehaviour
{
    private GameObject Character;
    private Character characterScript;
    private StarsNumber StarsNumberScript;
    private Transport transportScript;
    private GameObject Transport;
    private void Start()
    {
        Character = GameObject.Find("Story");
        characterScript = Character.GetComponent<Character>();
        Transport = GameObject.Find("Transport");
        StarsNumberScript = GetComponent<StarsNumber>();
        transportScript = Transport.GetComponent<Transport>();
    }
    public void ChargeStarsCount()
    {
        MoreAddStars();
    }

    private void MoreAddStars()
    {
        switch (characterScript.nowCustomer)
        {
            case People.AuntHua:
                {
                    switch(transportScript.thisProductsThing.transform.name )
                    {
                        case "RiYong":
                            JiSuan("ChunMian");
                            JiSuan("TuoYuan");
                            JiSuan("YunDuo");
                            break;
                        case "YeYong":
                            JiSuan("GanShuangWangMian");
                            JiSuan("ShuangHu");
                           if (transportScript.thisProductsThing.transform.childCount == 3)
                            { StarsNumberScript.starsNumber += 1; }
                            break;
                        case "ChaoChangYeYong":
                            JiSuan("ChunMian");
                            JiSuan("ChuangFang");
                            if (transportScript.thisProductsThing.transform.childCount == 3)
                            { StarsNumberScript.starsNumber += 1; }
                            break;
                        case "Hudian":
                            StarsNumberScript.starsNumber += 1;
                            JiSuan("JuanMian");
                            JiSuan("AiXin");
                            break;
                    }
                    StarsNumberScript.starsNumber += 5;
                    break;
                }
            case People.Xian:
                {
                    switch (transportScript.thisProductsThing.transform.name)
                    {
                        case "RiYong":
                            JiSuan("JuanMian");
                            JiSuan("ChangFang");
                            JiSuan("XiaoLian");
                            break;
                        case "YeYong":
                            JiSuan("JuanMian");
                            JiSuan("TuoYuan");
                            JiSuan("XiaoLian");
                            break;
                        case "ChaoChangYeYong":
                            JiSuan("JuanMian");
                            JiSuan("ShuangHu");
                            JiSuan("YunDuo");
                            break;
                        case "Hudian":
                            StarsNumberScript.starsNumber += 1;
                            JiSuan("ChunMian");
                            JiSuan("AiXin");
                            break;
                    }
                    StarsNumberScript.starsNumber += 2;
                    break;
                }
            case People.Weekand:
                {
                    switch (transportScript.thisProductsThing.transform.name)
                    {
                        case "RiYong":
                            JiSuan("ChunMian");
                            JiSuan("TuoYuan");
                            JiSuan("YunDuo");
                            break;
                        case "YeYong":
                            JiSuan("ChunMian");
                            JiSuan("TuoYuan");
                            JiSuan("YunDuo");
                            break;
                        case "ChaoChangYeYong":
                            JiSuan("JuanMian");
                            JiSuan("ShuangHu");
                            if (transportScript.thisProductsThing.transform.childCount == 3)
                            { StarsNumberScript.starsNumber += 1; }
                            break;
                        case "Hudian":
                            StarsNumberScript.starsNumber += 1;
                            JiSuan("ChunMian");
                            if (transportScript.thisProductsThing.transform.childCount == 2)
                            { StarsNumberScript.starsNumber += 1; }
                            break;
                    }
                    break;
                }
            case People.ColaJiang:
                {
                    switch (transportScript.thisProductsThing.transform.name)
                    {
                        case "RiYong":
                            JiSuan("GanShuangWangMian");
                            JiSuan("ShuangHu");
                            if (transportScript.thisProductsThing.transform.childCount == 3)
                            { StarsNumberScript.starsNumber += 1; }
                            break;
                        case "YeYong":
                            JiSuan("GanShuangWangMian");
                            JiSuan("ChangFang");
                            JiSuan("YunDuo");
                            break;
                        case "ChaoChangYeYong":
                            JiSuan("JuanMian");
                            JiSuan("TuoYuan");
                            JiSuan("AiXin");
                            break;
                        case "Hudian":
                            StarsNumberScript.starsNumber += 1;
                            JiSuan("ChunMian");
                            JiSuan("YunDuo");
                            break;
                    }
                    break;
                }
            case People.Cheng:
                {
                    switch (transportScript.thisProductsThing.transform.name)
                    {
                        case "RiYong":
                            JiSuan("JuanMian");
                            JiSuan("ChangFang");
                            JiSuan("AiXin");
                            break;
                        case "YeYong":
                            JiSuan("GanShuangWangMian");
                            JiSuan("TuoYuan");
                            JiSuan("AiXin");
                            break;
                        case "ChaoChangYeYong":
                            JiSuan("ChunMian");
                            JiSuan("ShuangHu");
                            JiSuan("YunDuo");
                            break;
                        case "Hudian":
                            StarsNumberScript.starsNumber += 1;
                            JiSuan("ChunMian");
                            JiSuan("YunDuo");
                            break;
                    }
                    break;
                }
        }
    }

    private void JiSuan(string name)
    {
        Transform childTransform = transportScript.thisProductsThing.transform.Find(name);
        if (childTransform != null)
        { StarsNumberScript.starsNumber += 1; }
    }
}
