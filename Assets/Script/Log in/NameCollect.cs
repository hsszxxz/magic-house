using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;

public class NameCollect : MonoBehaviour
{
    public string idname;
    public void NameInput(string id)
    {
        idname = id;
    }
    private void Start()
    {
        InputField input = this.transform.GetComponent<InputField>();
        input.onEndEdit.AddListener(NameInput);
    }
}
