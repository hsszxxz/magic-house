using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationAction : MonoBehaviour
{
    public  Animator anim;
    public Button button;
    private void Start()
    {
        anim = GetComponent<Animator>();
        button.onClick.AddListener(PlayOn);
    }
    public void PlayOn()
    {
        anim.enabled = true;
        Invoke("Close", 1f);
    }
    private void Close()
    { anim.enabled = false; }
}
