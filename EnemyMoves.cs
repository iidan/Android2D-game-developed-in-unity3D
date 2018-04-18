using UnityEngine;
using System.Collections;

public class EnemyMoves : MonoBehaviour
{
    public ObjectsPooler  EnemyPool;


    public void SpwanEnemy(Vector3 startpoint)
    {
        GameObject Enemy = EnemyPool.GetPooledObjects();
        Enemy.transform.position = new Vector3(startpoint.x, Random.Range(-0.3f, 3.398f), -0.006f);
        Enemy.SetActive(true);
    }

}
