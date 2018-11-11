﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.ControlSystem;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    protected int health = 5;
    [SerializeField]
    protected int maxHalth = 10;
    [SerializeField]
    protected float speed;

    protected Animator anim;

    public float Speed
    {
        get
        {
            return speed;
        }
    }

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    protected void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        ControlSystem.Move(transform, speed);
    }

    protected virtual void Recover(int health)
    {
        this.health +=  this.health + health <= maxHalth  ? health : this.health - maxHalth;
    }
}
