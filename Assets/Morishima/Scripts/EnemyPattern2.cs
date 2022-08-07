using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern2 : MonoBehaviour,IDamage
{
    private Vector3 _enemypattern2;

    [SerializeField]
    [Header("�U����")]
    private int _attack = 1;

    // Start is called before the first frame update
    void Start()
    {
        _enemypattern2 = transform.position;
        _attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //���Ԃ�z��-10�`30�̊Ԉړ�
        transform.position = new Vector3(_enemypattern2.x, _enemypattern2.y, Mathf.Sin(Time.time) * 20.0f + _enemypattern2.z);

        //y���ŉ�]���鏈��
        Quaternion Move_y = Quaternion.Euler(0f, 0.1f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }

    public int IDamege() => _attack;
}
