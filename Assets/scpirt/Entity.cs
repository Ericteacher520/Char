using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected int health = 100;

    public int Health
    {
        get { return health; }
        protected set { health = value; }
    }

    protected float speed = 2f;

    public int power = 10;

    public virtual void Damage(int damage)
    {
        if (damage < 0) return;
        if (Health - damage < 0 )
        {
            Health = 0;
            Destroy(gameObject);
        }
        else
        {
            Health -= damage;
        }
    }

    public abstract void moving();
}
