using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] Enemys;

    private void Start()
    {
        StartCoroutine(Generator());
    }

    IEnumerator Generator()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 10));
            int number = Random.Range(0, Enemys.Length);
            float x = Random.Range(-5.0f, 5.0f);
            float z = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, 0.0f, z);
            Instantiate(Enemys[number], pos, Quaternion.identity);
        }
    }
}
