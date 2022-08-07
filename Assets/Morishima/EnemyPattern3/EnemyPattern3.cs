using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern3 : MonoBehaviour
{
    private Vector3 enemypattern3;
    private int Attack;
    // Start is called before the first frame update
    void Start()
    {
        enemypattern3 = transform.position;
        Attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //ŠÔ‚Åx/z²ˆÚ“®
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + enemypattern3.x, enemypattern3.y, Mathf.Sin(Time.time) * 20.0f + enemypattern3.z);

        //y²‚Å‰ñ“]‚·‚éˆ—
        Quaternion Move_y = Quaternion.Euler(0f, 0.1f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }
}

