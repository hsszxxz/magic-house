using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsNumber : MonoBehaviour
{
    public int starsNumber = 0;
    private Text Stars;
    private void Start()
    {
        Stars = GetComponent<Text>();
    }
    private void Update()
    {
        Stars.text="¡Á"+ starsNumber.ToString();
    }
}
