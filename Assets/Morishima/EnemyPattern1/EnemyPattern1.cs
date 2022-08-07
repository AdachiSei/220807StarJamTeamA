using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern1 : MonoBehaviour
{
    private Vector3 enemypattern1;
    private int Attack;
    // Start is called before the first frame update
    void Start()
    {
        enemypattern1 = transform.position;
        Attack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //ŠÔ‚Åx²-20`20‚ÌŠÔˆÚ“®
        transform.position = new Vector3(Mathf.Sin(Time.time) * 20.0f + enemypattern1.x, enemypattern1.y, enemypattern1.z);
        
        //y²‚Å‰ñ“]‚·‚éˆ—
        Quaternion Move_y = Quaternion.Euler(0f, 0.1f, 0f);
        Quaternion y = this.transform.rotation;
        this.transform.rotation = y * Move_y;
    }
}
