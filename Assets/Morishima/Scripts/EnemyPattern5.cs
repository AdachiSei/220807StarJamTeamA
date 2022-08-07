using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern5 : MonoBehaviour
{
    private Vector3 _startPosition, _goalPosition;

    [SerializeField]
    [Header("�U����")]
    private int _attack = 1;

    // Start is called before the first frame update
    void Start()
    {
        //�X�^�[�g�ʒu
        _startPosition = new Vector3(-10, 0.75f, -15);
        //�܂�Ԃ��ʒu
        _goalPosition = new Vector3(-10, 0.75f, 20);

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
        pos.z += Speed;
        myTransform.position = pos;

        if (pos.z >= 20 && pos.x <= -10)
        {
            transform.position = _startPosition;
        }

        //y���ŉ�]���鏈��
        Quaternion Move_y = Quaternion.Euler(0.3f, 0.3f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }
}

