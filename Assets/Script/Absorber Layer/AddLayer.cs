using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AddLayer : MonoBehaviour
{
    private GameObject Transport;
    private Transport transportScript;
    private Preview method;
    private Button button;
    private GameObject thisThing;
    private VideoPlayer videoPlayer;
    private void Start()
    {
        Transport = GameObject.Find("Transport");
        transportScript = Transport.GetComponent<Transport>();
        method = GetComponent<Preview>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        videoPlayer = GetComponent<VideoPlayer>();
    }
    private void OnClick()
    {
        Invoke("Close", 1f);
        AttachLayer();
        videoPlayer.enabled = true;
    }

    private void AttachLayer()
    {
        for (int i = 1; i < transportScript.prodcutsTag.Length; i++)
        {
            method.AddNewImage("AbsorberLayer", transportScript.prodcutsTag[i], method.x, method.y, false, "Absorber", out thisThing);
            RectTransform layertTansform = transportScript.prodcutsTag[i].GetComponentInChildren<RectTransform>();
            layertTansform.localPosition = transportScript.prodcutsTag[i].transform.localPosition;
        }
    }
}
