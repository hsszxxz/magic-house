
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public enum People
    {
        AuntHua,
        Xian,
        Weekand,
        ColaJiang,
        Cheng
    }
    public People nowCustomer;
    private People[] character;
    public RectTransform[] characterTransform;
    private float time = 50f;
    public int i=4;
    private int prei=0;
    private bool flag=false;
    private bool first = true;
    public Transform[] characterTiShi;
    public float nowtime = 15f;
    private IEnumerator Start()
    {
        character = new People[5];
        character[0] = People.AuntHua;
        character[1] = People.Xian;
        character[2] = People.Weekand;
        character[3] = People.ColaJiang;
        character[4] = People.Cheng;
        characterTransform = new RectTransform[5];
        characterTransform[0] = transform.Find(character[0].ToString()).GetComponent<RectTransform>();
        characterTransform[1] = transform.Find(character[1].ToString()).GetComponent<RectTransform>();
        characterTransform[2] = transform.Find(character[2].ToString()).GetComponent<RectTransform>();
        characterTransform[3] = transform.Find(character[3].ToString()).GetComponent<RectTransform>();
        characterTransform[4] = transform.Find(character[4].ToString()).GetComponent<RectTransform>();
        while (true) 
        {
            nowtime = time;
            yield return new WaitForSeconds (time);
            ChargeTime();
            prei = i;
            i=ProduceRandom(prei);
            flag = false;
            first = false;
        }
    }
    private void Update()
    {
        nowtime-= Time.deltaTime;
        if (first)
        {
            float newY1 = Mathf.Sin(4 * Time.time) * 15f;
            if (characterTransform[i].localPosition.x == 50f)
            {
                characterTransform[i].localPosition = new Vector3(50f, 0, 0);
                characterTiShi[i].gameObject .SetActive(true);
            }
            else
            {
                characterTransform[i].localPosition = new Vector3(Mathf.MoveTowards(characterTransform[i].localPosition.x, 50f, 90 * Time.deltaTime), newY1, 0);
            }
        }
        else {PeopleMove(i,prei); }
    }
    private void PeopleMove(int i,int prei)
    {
         nowCustomer =character[i];
         float newY = Mathf.Sin(4* Time.time)*20f;
        if (characterTransform[prei].localPosition.x == 650f)
        {
            characterTransform[prei].localPosition = new Vector3(-530, 0, 0);
            flag = true;
        }
        else if (flag == false) 
        {
            characterTiShi[prei].gameObject .SetActive(false);
            characterTransform[prei].localPosition = new Vector3(Mathf.MoveTowards(characterTransform[prei].localPosition.x, 650f, 90 * Time.deltaTime), newY, 0);
            if (characterTransform[i].localPosition.x == 50f)
            {
                characterTransform[i].localPosition = new Vector3(50f, 0, 0);
                characterTiShi[i].gameObject.SetActive(true);
            }
            else
            { 
                characterTransform[i].localPosition = new Vector3(Mathf.MoveTowards(characterTransform[i].localPosition.x, 50f, 90 * Time.deltaTime), newY, 0);
            }
            
        }
    }
    private int ProduceRandom(int prei)
    {
        float randomNumber = Random.value;
        if (randomNumber < 0.1f )
        {
            if (prei == 0) { return ProduceRandom(prei); }
            else return 0;
        }
        else if (randomNumber < 0.25f )
        {
            if (prei == 1) { return ProduceRandom(prei); }
            else return 1;
        }
        else if (randomNumber < 0.5f )
        {
            if (prei == 2) { return ProduceRandom(prei); }
            else return 2;
        }
        else if(randomNumber < 0.75 )
        {
            if (prei == 3) { return ProduceRandom(prei); }
            else return 3;
        }
        else
        {
            if (prei == 4) { return ProduceRandom(prei); }
            else return 4;
        }
    }
    private void ChargeTime()
    {
        switch(nowCustomer)
        {
            case People.AuntHua: 
                {
                    time = 30f; 
                    break;
                }
            case People.Xian:
                {
                    time = 40f;
                    break;
                }
            case People.Weekand:
                {
                    time = 40f;
                    break;
                }
            case People.ColaJiang:
                {
                    time =Random.Range(30f,50f);
                    break;
                }
            case People.Cheng:
                {
                    time = 50f;
                    break;
                }
        } 
    }
}
