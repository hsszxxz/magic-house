using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShuoMing : MonoBehaviour
{
    public GameObject Tishi;
    private void OnClickAttach()
    {
        Tishi.SetActive(true);
    }
    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClickAttach);
    }
}
