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
        Debug.Log("�X�R�A�{�[�i�X�l���I");
        ScoreManeger.Instance.ScoreUp();
    }
}
