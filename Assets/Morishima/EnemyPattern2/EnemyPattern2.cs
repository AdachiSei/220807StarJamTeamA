using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern2 : MonoBehaviour
{
    private Vector3 enemypattern2;
    private int Attack;
    // Start is called before the first frame update
    void Start()
    {
        enemypattern2 = transform.position;
        Attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //ŠÔ‚Åz²-10`30‚ÌŠÔˆÚ“®
        transform.position = new Vector3(enemypattern2.x, enemypattern2.y, Mathf.Sin(Time.time) * 20.0f + enemypattern2.z);

        //y²‚Å‰ñ“]‚·‚éˆ—
        Quaternion Move_y = Quaternion.Euler(0f, 0.1f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }
}
