using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed => _speed;
    public int Life => _life;

    [SerializeField]
    [Header("�X�s�[�h")]
    float _speed = 5;

    [SerializeField]
    [Header("�̗�")]
    int _life;

    Rigidbody _rb;
    const string DEATH_ZONE_TAG = "Finish";

    void Awake()
    {
        if (TryGetComponent(out _rb))
        {
            Debug.Log("�v���C���[��Rigitbody���Q�Ƃł���");
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
            Debug.Log("�G�ɐG�ꂽ");
            //�����œG�������Ă�֐����Ăяo��


            if(_life < 0)
            {
                GameOver();
            }
        }
        else if(collision.gameObject.TryGetComponent(out Rigidbody t2))
        {
            Debug.Log("�A�C�e���ɐG�ꂽ");
            //�A�C�e���������Ă�֐����Ăяo��
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
        Debug.Log("�Q�[���I�[�o�[");
        ResultUIManager.Instance.ResultSetActive(true);
        Destroy(gameObject);
    }
}
