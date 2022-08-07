using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern3 : MonoBehaviour,IDamage
{
    private Vector3 _enemypattern3;

    [SerializeField]
    [Header("UŒ‚—Í")]
    private int _attack = 1;

    // Start is called before the first frame update
    void Start()
    {
        _enemypattern3 = transform.position;
        _attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //ŠÔ‚Åx/z²ˆÚ“®
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + _enemypattern3.x, _enemypattern3.y, Mathf.Sin(Time.time) * 20.0f + _enemypattern3.z);

        //y²‚Å‰ñ“]‚·‚éˆ—
        Quaternion Move_y = Quaternion.Euler(0f, 0.1f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }

    public int IDamege() => _attack;
}

