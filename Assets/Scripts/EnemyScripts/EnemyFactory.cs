﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

[CreateAssetMenu]
public class EnemyFactory : ScriptableObject
{
    public static EnemyFactory enemyF;

    [SerializeField]
    public Enemy enemyPrefab = default;

    [SerializeField]
    public TEnemy tEnemyPrefab = default;

    [SerializeField]
    public DpsEnemy dpsEnemyPrefab = default;

    public Enemy GetEnemy()
    {
        Vector3 Position = new Vector3();
        Position.x = Random.Range(0f, 198f);
        Position.y = 8f;
        Position.z = Random.Range(0f, 103f);
        Enemy instance = Instantiate(enemyPrefab,Position,Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public TEnemy GetTEnemy()
    {
        Vector3 Position = new Vector3();
        Position.x = Random.Range(0f, 198f);
        Position.y = 20f;
        Position.z = Random.Range(0f, 103f);
        TEnemy instance = Instantiate(tEnemyPrefab, Position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public DpsEnemy GetDpsEnemy()
    {
        Vector3 Position = new Vector3();
        Position.x = Random.Range(0f, 198f);
        Position.y = 20f;
        Position.z = Random.Range(0f, 103f);
        DpsEnemy instance = Instantiate(dpsEnemyPrefab, Position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public Enemy GetAroundEnemy(Vector3 spawnPosition,Enemy enemyPrefab00)
    {
        Enemy instance = Instantiate(enemyPrefab00, spawnPosition, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;

    }

    public void Reclaim(Enemy enemy)
    {
        //Debug.Assert(enemy == this, "Wrong Factory Reclaimed!");
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

    public Enemy CreateCommonEnemyInOtherWorld(Vector3 position)
    {
        Enemy instance = Instantiate(enemyPrefab, position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public Enemy CreateTEnemyInOtherWorld(Vector3 position)
    {
        Enemy instance = Instantiate(tEnemyPrefab, position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    public Enemy CreatedpsEnemyInOtherWorld(Vector3 position)
    {
        Enemy instance = Instantiate(dpsEnemyPrefab, position, Quaternion.identity);
        instance.OriginFactory = this;
        return instance;
    }

    private void OnEnable()
    {
        enemyF = this;
    }

    private void Awake()
    {
        enemyF = this;
    }
}
