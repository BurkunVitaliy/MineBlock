using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BackgroundTile : MonoBehaviour
{
    public GameObject[] cells;


    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        int cellToUse = Random.Range(0, cells.Length);
        GameObject cell = Instantiate(cells[cellToUse], transform.position, Quaternion.identity);
        cell.transform.parent = transform;
        cell.name = gameObject.name;
    }
}
