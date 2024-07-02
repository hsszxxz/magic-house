using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdName : MonoBehaviour
{
    private Text idName;
    private NameCollect prename;
    public GameObject Name;
    public string ids;
    private void Start()
    {
        prename = Name.GetComponent<NameCollect>();
        idName = GetComponent<Text>();
        idName.text ="ID:"+ prename.idname;
    }
}
