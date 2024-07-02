using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragMaterial : MonoBehaviour
{
    private Preview method;
    private Transport transportScript;
    private GameObject transport;
    private GameObject thisThing;
    public Color needColor;
    private void OnClickAttach()
    {
        string attachName = this.transform.name;
        method.AddNewImage(attachName, transportScript.thisProductsThing, method.x, method.y, false, "AddThing", out thisThing);
        transportScript.thisProductsThing.transform.Find(transportScript.thisProductsThing.transform.name).GetComponent<Image>().color = needColor;
     }
    private void Start()
    {
        method = GetComponent<Preview>();
        transport = GameObject.Find("Transport");
        transportScript = transport.GetComponent<Transport>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClickAttach);
    }
}
