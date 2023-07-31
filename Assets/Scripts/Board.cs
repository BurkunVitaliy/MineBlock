using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width, height;
    public GameObject tilePrefabs;
    private BackgroundTile[,] allTiles;

    private void Start()
    {
        allTiles = new BackgroundTile[width, height];
        SetUp();
    }

    private void SetUp()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPosition = new Vector2(i, j);
;                Instantiate(tilePrefabs,tempPosition,Quaternion.identity);
            }
        }
    }
}
