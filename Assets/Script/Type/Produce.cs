using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Produce : MonoBehaviour
{
    private Preview method;
    private Transport transportScript;
    private GameObject transport;
    private GameObject thisThing;
    private Button button;
    public GameObject buttonAdd;
    private  void ProducePicture()
    {
        name = this.transform.name;
        method.AddNewImage(name, transport, method.x, method.y, true, "Product", out thisThing);
        transportScript.L += 250;
        buttonAdd.SetActive(false);
        Invoke("QiDong", 3f);
    }

    private void  QiDong()
    {
        buttonAdd.SetActive(true);
    }

    private void Start()
    {
        method = GetComponent<Preview>();
        transport = GameObject.Find("Transport");
        transportScript = transport.GetComponent<Transport>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ProducePicture);
    }
}
