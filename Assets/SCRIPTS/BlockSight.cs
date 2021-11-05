﻿using System;
using UnityEngine;
 [Serializable]
public class BlockSight
{
    [SerializeField]
    private GameObject first, second;
    public void Deactivate()
    {
        first.SetActive(false);
        second.SetActive(false);
    }  public void Activate()
    {
        first.SetActive(true);
        second.SetActive(true);
    }
 
}
