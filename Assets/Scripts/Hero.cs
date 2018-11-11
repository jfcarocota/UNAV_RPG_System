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
    protected bool isSelected = false;

    Transform partyLeader;

    private void Start()
    {
        partyLeader = GameObject.Find("wizardgirl@set").transform;
    }

    protected override void Move()
    {
        if (isSelected)
        {
            transform.Translate(Vector3.forward * ControlSystem.Axis.magnitude * speed * Time.deltaTime);

            if (ControlSystem.Axis != Vector2.zero)
            {
                transform.rotation = Quaternion.LookRotation(new Vector3(ControlSystem.Axis.x, 0f, ControlSystem.Axis.y));
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, partyLeader.position) > 1.2f)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                transform.LookAt(partyLeader);
            }
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
}

