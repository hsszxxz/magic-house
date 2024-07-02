using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DragProduct : MonoBehaviour
{
    private GameObject Trash;
    private Vector3 oralposition;
    private GameObject Transport;
    private Transport script;
    private GameObject Character;
    private Character characterScript;
    private StarsCount starscountScript;
    private GameObject Stars;
    private void Start()
    {
        Trash = GameObject.Find("Trash");
        oralposition = transform.position;
        Transport = GameObject.Find("Transport");
        script = Transport.GetComponent<Transport>();
        Character = GameObject.Find("Story");
        characterScript = Character.GetComponent<Character>();
        Stars = GameObject.Find("Stars");
        starscountScript = Stars.GetComponent<StarsCount>();
    }
    public void OnDragProduct()
    {
        Vector3 dragPos = Input.mousePosition;
        this.transform.position = dragPos;
    }
    public void OnEndProductDrag()
    {
        if (Vector3.Distance(this.transform.position,Trash.transform.position) <=60)
        {
            foreach (Transform t in this.transform)
            {
                Destroy(t.gameObject);
            }
            Destroy(script.prodcutsTag [0].gameObject);
            script.L -= 250;
        }
        else if (Vector3.Distance(this.transform.position, characterScript.characterTransform[characterScript.i].transform.position) <= 60)
        {
            starscountScript.ChargeStarsCount();
            foreach (Transform t in this.transform)
            {
                Destroy(t.gameObject);
            }
            Destroy(script.prodcutsTag[0].gameObject);
            script.L -= 250;
        }
        else
        {
            this.transform.position   = oralposition;
        }
    }
}
