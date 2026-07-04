# EBAC - Curso Unity: Do Zero ao Pro

## Módulo 5 - Introdução ao C#: Avançado - Parte 1

Este projeto aplica conceitos de **Herança**, **Polimorfismo** e **Scriptable Objects** para criar um sistema de inimigos na Unity.

### `BaseEnemy.cs`

```csharp
using System;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public EnemyData data;
    protected int _health;
    protected float _power;

    protected virtual void Awake()
    {
        this.SetupStats();
    }

    protected virtual void SetupStats()
    {
        _health = data.health;
        _power = data.power;
    }
}

```

### `Enemy.cs`

```csharp
using System;
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

```

### `EnemyRun.cs`

```csharp
using System;
using UnityEngine;

public class EnemyRun : BaseEnemy
{
    private float _speed = 0f;

    protected override void Awake()
    {
        base.Awake();
        
        print("Enemy Run Data: \n");
        print("Health: " + this._health);
        print("Power: " + this._power);
        print("Speed: " + this._speed);
    }

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

```

### `EnemyData.cs`

```csharp
using UnityEngine;

[CreateAssetMenu]
public class EnemyData : ScriptableObject
{
    public int health = 0;
    public float power = 0;
}

```

### `EnemyRunData.cs`

```csharp
using UnityEngine;

[CreateAssetMenu]
public class EnemyRunData : EnemyData
{
    public float speed;
}

```
