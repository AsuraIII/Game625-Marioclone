using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public float spawnTime = 3.0f;


    private void Start()
    {

        StartCoroutine(ObjectSpawn(spawnTime));
    }

    private IEnumerator ObjectSpawn(float time)
    {
        while (true)
        {
            RandomItem();
            yield return new WaitForSeconds(time);
        }
    }

    public void RandomItem()
    {
        float ranNum = Random.Range(0f, 10f);
        if (ranNum > 8.0f)
        {
            ObjectPooler._instance.SpawnFromPool(ObjectType.PowerUp, RandomPosition());
        }
        else
        {
            ObjectPooler._instance.SpawnFromPool(ObjectType.Coin, RandomPosition());
        }
    }

    public Vector3 RandomPosition()
    {
        float xRandom = Random.Range(-20.0f, 20.0f);
        float yRandom = Random.Range(0.0f, 15.0f);

        Vector2 randomPos = new Vector2(xRandom, yRandom);
        return randomPos;
    }

    public void InitialSpawn()
    {

    }
}
