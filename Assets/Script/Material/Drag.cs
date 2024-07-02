using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{
    private Preview method;
    private GameObject dragThing;
    private RectTransform dragThingTransform;
    private GameObject thisThing;
    private GameObject transport;
    private Transport transportScript;
    private string dragName;
    private void Start()
    {
       dragThing = GameObject.Find("DragThing");
        transport = GameObject.Find("Transport");
        transportScript = transport.GetComponent<Transport>();
        method = GetComponent<Preview>();
        dragThingTransform = dragThing.GetComponent<RectTransform>();
        dragName = this.gameObject.name;
    }
    public void OnDrag()
    {
        if (dragThing.transform.childCount > 0)
        {
            Destroy(dragThing.transform.GetChild(0).gameObject);
        }
        dragName = this.gameObject.name;
        method.AddNewImage(dragName, dragThing, method.x, method.y, false,"DragThing", out thisThing);
        Vector3 dragPos = Input.mousePosition;
        dragThing.transform.position = dragPos;
        dragThingTransform.sizeDelta = new Vector2(method.x, method.y);
    }
    public void OnEndDrag()
    {
        if (Vector3.Distance(dragThing.transform.position, transportScript.thisProductsThing.transform.position) <= 60)
        {
            method.AddNewImage(dragName, transportScript.thisProductsThing , method.x, method.y, false, "AddThing", out thisThing);
        }
        foreach (Transform t in dragThing.transform )
        {
            Destroy (t.gameObject);
        }
        dragThing.transform.position = new Vector2 (-200, 150);
    }
    
}
