﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square {
    public int Row { get; set; }
    public int Column { get; set; }
    public int Value { get; set; }
    public int Section { get; set; }
    public bool Locked { get; set; }
    public List<int> AvailableValues { get; set; }

    public Square(int row, int column, int section)
    {
        this.Row = row;
        this.Column = column;
        this.Value = 0;
        this.Section = section;
        this.Locked = true;
        this.AvailableValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public void ResetAvailableValues()
    {
        this.AvailableValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public void SetValue(int value)
    {
        this.Value = value;
        this.AvailableValues.Remove(value);
    }

    public void UnsetValue()
    {
        this.Value = 0;
    }

    public void LockSquare() { this.Locked = true; }
    public void UnlockSquare() { this.Locked = false; }
	
}
