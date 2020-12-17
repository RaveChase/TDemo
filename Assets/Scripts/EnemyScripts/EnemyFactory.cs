﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyFactory : ScriptableObject
{
    [SerializeField]
    public Enemy enemyPrefab = default;

    [SerializeField]
    public TEnemy tEnemyPrefab = default;

    [SerializeField]
    public DpsEnemy dpsEnemyPrefab = default;

    public Enemy GetEnemy()
    {
        Vector3 Position = new Vector3(Random.Range(-20f, 20f), 0f, Random.Range(-20f, 20f));
        Enemy instance = Instantiate(enemyPrefab,Position,Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public TEnemy GetTEnemy()
    {
        Vector3 Position = new Vector3(Random.Range(-20f, 20f), 0f, Random.Range(-20f, 20f));
        TEnemy instance = Instantiate(tEnemyPrefab, Position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public DpsEnemy GetDpsEnemy()
    {
        Vector3 Position = new Vector3(Random.Range(-20f, 20f), 0f, Random.Range(-20f, 20f));
        DpsEnemy instance = Instantiate(dpsEnemyPrefab, Position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public void Reclaim(Enemy enemy)
    {
        Debug.Assert(enemy == this, "Wrong Factory Reclaimed!");
        Destroy(enemy.gameObject);
    }

    public void Reclaim(TEnemy tEnemy)
    {
        Debug.Assert(tEnemy == this, "Wrong Factory Reclaimed!");
        Destroy(tEnemy.gameObject);
    }

    public void Reclaim(DpsEnemy dpsEnemy)
    {
        Debug.Assert(dpsEnemy == this, "Wrong Factory Reclaimed!");
        Destroy(dpsEnemy.gameObject);
    }
}
