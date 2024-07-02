using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using Unity.VisualScripting;

public class Transport : MonoBehaviour
{
    public float L = -500;
    private GameObject dragProduct;
    private RectTransform dragProductRectTransform;
    private Preview method;
    private bool flag;
    public GameObject[] prodcutsTag;
    public GameObject thisProductsThing;
    private GameObject thisThingChild;
    public Transform[] thisThingChildren;
    private void Start()
    {
        dragProduct = GameObject.Find("Product");
        dragProductRectTransform = dragProduct.GetComponent <RectTransform>();
        method = GetComponent<Preview>();
        prodcutsTag = new GameObject[4];
    }
    void Update()
    {
        prodcutsTag = GameObject.FindGameObjectsWithTag("Product");
        if (prodcutsTag.Count() <= 3 && prodcutsTag.Count()> 0)
        {
            ProductsMove(prodcutsTag);
            flag = true;
        }
        else if (prodcutsTag.Count() == 0) { L = -500; }
        else if (flag)
        {
            prodcutsTag = GameObject.FindGameObjectsWithTag("Product");
            OnDragWeiShengJin(prodcutsTag);
            VanishPicture();
            flag = false;
        }
    }

    private void VanishPicture()
    {
        Image lastProduct = prodcutsTag[0].GetComponent<Image>();
        Image[] image2 = prodcutsTag[0].GetComponentsInChildren<Image>();
        Color color = lastProduct.color;
        color.a = 0;
        lastProduct.color = color;
        foreach (Image image in image2)
        {
            Color color2 = image.color;
            color2.a = 0;
            image.color = color2;
        }
    }

    private void ProductsMove(GameObject [] products)
    {
        foreach (GameObject  product in products)
        {
            int index = Array.IndexOf(products, product);
            RectTransform transportTransform = this.GetComponent<RectTransform>();
            RectTransform productTransform = product.GetComponent<RectTransform>();
            Vector3 transportPosition = transportTransform.position;
            productTransform.localPosition = new Vector3(Mathf.MoveTowards(productTransform.localPosition.x, L -index*250, 90 * Time.deltaTime), 0, 0);
            transportTransform.position = transportPosition;
        }
    }
    private void OnDragWeiShengJin(GameObject [] fallProducts) 
    {
        Transform fallproductTransform = fallProducts[0].GetComponent<Transform>();
        dragProductRectTransform.transform.position = fallproductTransform.position;
        string nameProduct = fallProducts[0].transform.name;
        method.AddNewImage(nameProduct, dragProduct, method.x, method.y, false,"DragThing",out thisProductsThing);
        thisThingChildren = fallProducts[0].GetComponentsInChildren<Transform>() ;
        foreach (Transform child in thisThingChildren)
        {
            method.AddNewImage(child.name, thisProductsThing, method.x, method.y, false, "DragThing", out thisThingChild);
        }
    }
}
