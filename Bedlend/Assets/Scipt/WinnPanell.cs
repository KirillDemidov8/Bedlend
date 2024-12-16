using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnPanell : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    public static WinnPanell Instance
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
    static private WinnPanell _instance;

    public void WinPanell()
    {
        Panel.SetActive(true);
    }
}
