using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern1 : MonoBehaviour
{
    private Vector3 _enemypattern1;

    [SerializeField]
    [Header("UŒ‚—Í")]
    private int _attack = 1;

    // Start is called before the first frame update
    void Start()
    {
        _enemypattern1 = transform.position;
        _attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //ŠÔ‚Åx²-20`20‚ÌŠÔˆÚ“®
        transform.position = new Vector3(Mathf.Sin(Time.time) * 20.0f + _enemypattern1.x, _enemypattern1.y, _enemypattern1.z);
        
        //y²‚Å‰ñ“]‚·‚éˆ—
        Quaternion Move_y = Quaternion.Euler(0f, 0.1f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;      
    }
}
