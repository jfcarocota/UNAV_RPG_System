using UnityEngine;
using Core.PartySystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    PartySystem partySystem;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else if (instance != this)
        {
            Destroy(this);
        }

        partySystem.StartParty();
    }

    public PartySystem PartySystem
    {
        get
        {
            return partySystem;
        }
    }
}

