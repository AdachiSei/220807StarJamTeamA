using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern4 : MonoBehaviour,IDamage
{
    private Vector3 _startPosition, _goalPosition;

    [SerializeField]
    [Header("攻撃力")]
    private int _attack = 1;

    // Start is called before the first frame update
    void Start()
    {
        //スタート位置
        _startPosition = new Vector3(20, 0.75f, 0);
        //折り返し位置
        _goalPosition = new Vector3(-20, 0.75f, 0);

        _attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //移動速度
        float Speed = 0.03f;
        Transform myTransform = this.transform;
        
        //座標を取得
        Vector3 pos = myTransform.position;

        //移動処理
        pos.x -= Speed;
        myTransform.position = pos;

        if (pos.x <= -20)
        {
            transform.position = new Vector3(20, 0.75f, -10);
        }
        if (pos.x <= -20 && pos.z <= -10)
        {
            transform.position = new Vector3(20, 0.75f, 10);
        }
        if (pos.x <= -20 && pos.z >= 10)
        {
            transform.position = _startPosition;
        }

        //y軸で回転する処理
        Quaternion Move_y = Quaternion.Euler(0.3f, 0.3f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }

    public int IDamege() => _attack;
}

