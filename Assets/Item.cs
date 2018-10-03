using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string DisplayName;
    public float Weight;
    public float cost;
    public float GetpricePerWeight()
    {
        return cost / Weight;
    }

    public void OnMouseEnter()
    {
        Debug.Log(ToString());
    }
    public override string ToString()
    {
        return "This is a " + DisplayName + " and it weighs " +Weight+ ". It costs "+ GetpricePerWeight() +" Gold Coins per kilo.";
    }

    void Start()
    {
    }
    void Update()
    {

    }
}
