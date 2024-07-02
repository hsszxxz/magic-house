using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiShiButton : MonoBehaviour
{
    public GameObject[] TishiPicture;
    private int index = 0;
    private Button button;
    private void OnClickAttach()
    {
        if (index< 5) 
        {
            TishiPicture[index].SetActive(false);
            TishiPicture[index+1].SetActive(true);
            index++;
        }
        else if (index == 5) 
        {
            button.interactable = false; 
        }
    }
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickAttach);
    }
}
