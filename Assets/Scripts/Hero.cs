using System;
using UnityEngine;
using Core.ControlSystem;

public abstract class Hero : Character
{
    [SerializeField]
    protected string lore;
    [SerializeField]
    protected Sprite icon;

    [SerializeField]
    private bool isSelected = false;

    protected override void Move()
    {
        if (!isSelected) return;
        transform.Translate(Vector3.forward * ControlSystem.Axis.magnitude * speed * Time.deltaTime);
        
        if(ControlSystem.Axis != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(ControlSystem.Axis.x, 0f, ControlSystem.Axis.y));
        }
    }

    //[SerializeField]
    //Inventory inventory;

    protected override void Recover(int health)
    {
        base.Recover(health);
    }

    public Vector3 Position
    {
        get { return transform.position; }
    }

    public bool IsSelected
    {
        get
        {
            return isSelected;
        }

        set
        {
            isSelected = value;
        }
    }
}

