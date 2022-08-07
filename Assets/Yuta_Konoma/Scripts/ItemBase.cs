using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase 
{
    public virtual void Use()
    {
        Debug.Log(this.ToString() + "‚ğE‚Á‚½");
    }
}
