using System;
using UnityEngine;


public class EnemyRun : BaseEnemy
{

    private float _speed = 0f;


    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        this.transform.Translate(new Vector3(0f, 0f, this._speed * Time.fixedDeltaTime));
    }

    protected override void SetupStats()
    {
        base.SetupStats();
        if(data is EnemyRunData _data)
        {
            _speed = _data.speed;
        }
    }
}