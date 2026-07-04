using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Enemy : BaseEnemy
{
    protected override void Awake()
    {
        base.Awake();
        
        print("Enemy Data: \n");
        print("Health: " + this._health);
        print("Power: " + this._power);
    }
}
