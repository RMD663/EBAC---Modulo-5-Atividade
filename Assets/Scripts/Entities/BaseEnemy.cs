using System;
using UnityEngine;


public class BaseEnemy : MonoBehaviour
{

    public EnemyData data;
    protected int _health;
    protected float _power;

    void Awake()
    {
        this.SetupStats();
    }

    protected virtual void SetupStats()
    {
        _health = data.health;
        _power = data.power;
    }
}