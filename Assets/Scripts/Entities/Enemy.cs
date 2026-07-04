using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    EnemyData data;

    private int _health;

    void Awake()
    {
        SetupData();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupData()
    {
        this._health = data.health;
    }
}
