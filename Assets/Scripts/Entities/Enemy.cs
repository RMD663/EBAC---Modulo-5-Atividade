using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Enemy : BaseEnemy
{
    void Awake()
    {
        this.SetupStats();
        print("Enemy Data: \n");
        print("Health: " + this._health);
        print("Power: " + this._power);
    }
}
