using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : ItemBase
{
    public void Start()
    {
   
    }
    public override void Use()
    {
        base.Use();       
        Debug.Log("スコアボーナス獲得！");
        ScoreManeger.Instance.ScoreUp();
    }
}
