using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject Panell;
    public static GameOver Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    static private GameOver _instance;

    public void Gameover()
    {
        Panell.SetActive(true);
    }

}
