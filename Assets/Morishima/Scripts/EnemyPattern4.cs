using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern4 : MonoBehaviour,IDamage
{
    private Vector3 _startPosition, _goalPosition;

    [SerializeField]
    [Header("�U����")]
    private int _attack = 1;

    // Start is called before the first frame update
    void Start()
    {
        //�X�^�[�g�ʒu
        _startPosition = new Vector3(20, 0.75f, 0);
        //�܂�Ԃ��ʒu
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
        //�ړ����x
        float Speed = 0.03f;
        Transform myTransform = this.transform;
        
        //���W���擾
        Vector3 pos = myTransform.position;

        //�ړ�����
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

        //y���ŉ�]���鏈��
        Quaternion Move_y = Quaternion.Euler(0.3f, 0.3f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }

    public int IDamege() => _attack;
}

