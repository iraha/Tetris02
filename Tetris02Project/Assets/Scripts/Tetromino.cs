﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{

    float fall = 0;
    [SerializeField] public float fallSpeed = 1f;

    void Update()
    {
        CheckUserInput();

    }

    private void CheckUserInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (CheckIsValidPosition()) 
            {
                
            } 
            else 
            {
                transform.position += new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (CheckIsValidPosition())
            {

            }
            else
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, 90);

            if (CheckIsValidPosition()) 
            {

            } 
            else 
            {
                transform.Rotate(0, 0, -90);
            }

            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - fall >= fallSpeed)
        {
            transform.position += new Vector3(0, -1, 0);

            if (CheckIsValidPosition())
            {

            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
            }
            fall = Time.time;
            
        }
    }

    bool CheckIsValidPosition() 
    {

        foreach (Transform mino in transform) 
        {
            Vector2 pos = FindObjectOfType<Game>().Round(mino.position);
            if (FindObjectOfType<Game>().CheckIsInsideGrid(pos) == false) 
            {
                return false;
            }
        }

        return true;
    }
    


}
