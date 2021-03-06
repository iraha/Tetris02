﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public static int gridWidth = 10;
    public static int gridHeight = 20;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // テトリスが外に出ないように制御
    public bool CheckIsInsideGrid(Vector2 pos) 
    {
        return ((int)pos.x >= 0 && (int)pos.x < gridWidth && (int)pos.y >= 0);
    }

    public Vector2 Round(Vector2 pos) 
    {
        // Mathf.Round = 四捨五入
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

}
