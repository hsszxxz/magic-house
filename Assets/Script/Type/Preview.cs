using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preview : MonoBehaviour
{
    private Image img;
    public int x;
    public int y;
    private GameObject thisThing;
   public void PointerEnterPreview ()
    {
        string name = this.transform.name;
        GameObject parent = GameObject.Find("Preview");
        if (parent.transform.childCount > 0)
        {
            Destroy(parent.transform.GetChild(0).gameObject);
        }
        AddNewImage(name, parent, x,y,false,"Preview" ,out thisThing);
    }

    public void AddNewImage(string name, GameObject parent,int x, int y,bool t,string tag,out GameObject thisThing)
    {
        GameObject preview = new GameObject(name);
        preview.AddComponent<Image>();
        preview.transform.SetParent(parent.transform, false);
        preview.tag = tag;
        img = preview.GetComponent<Image>();
        img.sprite = Resources.Load<Sprite>(img.name);
        RectTransform rectTransform = img.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(x, y);
        if (t) { rectTransform.localPosition = new Vector2(-500, -3); }
        thisThing =preview;
    }
}
