using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    void Start()
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
    }

    [SerializeField]
    Hero hero;

    public Hero Hero
    {
        get
        {
            return hero;
        }
    }
}

