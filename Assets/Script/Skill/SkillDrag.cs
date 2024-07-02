using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkillDrag : MonoBehaviour
{
    private Preview method;
    private GameObject dragThing;
    private RectTransform dragThingTransform;
    private GameObject thisThing;
    private GameObject character;
    private Character characterScript;
    private string dragName;
    private StarsNumber stars;
    private GameObject Star;
    private void Start()
    {
        dragThing = GameObject.Find("DragThing");
        character = GameObject.Find("Story");
        characterScript = character.GetComponent<Character>();
        method = GetComponent<Preview>();
        dragThingTransform = dragThing.GetComponent<RectTransform>();
        dragName = this.gameObject.name;
        Star = GameObject.Find("Stars");
        stars = Star.GetComponent<StarsNumber>();
    }
    public void OnDrag()
    {
        if (dragThing.transform.childCount > 0)
        {
            Destroy(dragThing.transform.GetChild(0).gameObject);
        }
        dragName = this.gameObject.name;
        method.AddNewImage(dragName, dragThing, method.x, method.y, false, "DragThing", out thisThing);
        Vector3 dragPos = Input.mousePosition;
        dragThing.transform.position = dragPos;
        dragThingTransform.sizeDelta = new Vector2(method.x, method.y);
    }
    public void OnEndDrag()
    {
        if (Vector3.Distance(dragThing.transform.position, characterScript.characterTransform[characterScript.i].transform.position) <= 60)
        {
            stars.starsNumber += Random.Range(1, 3);
        }
        foreach (Transform t in dragThing.transform)
        {
            Destroy(t.gameObject);
        }
        dragThing.transform.position = new Vector2(-200, 150);
    }
}
