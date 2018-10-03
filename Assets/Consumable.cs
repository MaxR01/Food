using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    public float Uses;
    public float MaxUses;

    public void OnMouseUpAsButton()
    {
        Use();
    }
    public void Use()
    {
        Uses -= 1;
        if (Uses > 0)
        {
            print(Usetext());
        }
        else
        {
            print(NoUsesRemaningText());
        }
    }
    public virtual string Usetext()
    {
        return "You ate a " + DisplayName + ". and you have " + Uses + " Left.";
    }
    public string NoUsesRemaningText()
    {
        return "You have 0 uses left";
    }
    public override string ToString()
    {
        return base.ToString();
    }
    void Start()
    {
    }
    void Update()
    {

    }
}
