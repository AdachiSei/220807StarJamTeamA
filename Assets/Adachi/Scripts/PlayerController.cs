using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed => _speed;
    public int Life => _life;

    [SerializeField]
    [Header("スピード")]
    float _speed = 5;

    [SerializeField]
    [Header("体力")]
    int _life;

    Rigidbody _rb;
    const string DEATH_ZONE_TAG = "Finish";

    void Awake()
    {
        if (TryGetComponent(out _rb))
        {
            Debug.Log("プレイヤーのRigitbodyを参照できた");
        }
        else
        {
            _rb = gameObject.AddComponent<Rigidbody>().GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        OnMove();     
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Rigidbody t1))
        {
            Debug.Log("敵に触れた");
            //ここで敵が持ってる関数を呼び出す


            if(_life < 0)
            {
                GameOver();
            }
        }
        else if(collision.gameObject.TryGetComponent(out Rigidbody t2))
        {
            Debug.Log("アイテムに触れた");
            //アイテムが持ってる関数を呼び出す
        }
        else if(collision.gameObject.tag == DEATH_ZONE_TAG)
        {
            GameOver();
        }
    }

    void OnMove()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");
        _rb.AddForce(h, _rb.velocity.y, v);
    }

    void GameOver()
    {
        Debug.Log("ゲームオーバー");
        ResultUIManager.Instance.ResultSetActive(true);
        Destroy(gameObject);
    }
}
