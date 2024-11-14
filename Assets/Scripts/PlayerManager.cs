using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager instance;

    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("PlayerManager");
                    instance = obj.AddComponent<PlayerManager>();
                }
            }

            return instance;
        }
    }

    public PlayerStateData playerStateData;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        playerStateData = Resources.Load<PlayerStateData>("PlayerStateData");
    }
}
