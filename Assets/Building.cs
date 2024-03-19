using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour, IDamageable
{
    public int Hp { get; set; }

    public virtual void Build(Vector3 position) { 
        transform.position = position;
    }

    public virtual void Destroy()
    {
        Destroy(gameObject);
    }

    public abstract void Upgrade();

    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        throw new System.NotImplementedException();
    }
}
