using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PermittedValues {
    // Create a dictionary to hold all row permitted values
    public static Dictionary<int, List<int>> row_PermittedValues = new Dictionary<int, List<int>>()
    {
        { 1, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 2, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 3, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 4, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 5, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 6, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 7, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 8, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 9, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } }
    };

    // Create a dictionary to hold all column permitted values
    public static Dictionary<int, List<int>> column_PermittedValues = new Dictionary<int, List<int>>()
    {
        { 1, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 2, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 3, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 4, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 5, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 6, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 7, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 8, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 9, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } }
    };

    // Create a dictionary to hold all section permitted values
    public static Dictionary<int, List<int>> section_PermittedValues = new Dictionary<int, List<int>>()
    {
        { 1, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 2, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 3, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 4, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 5, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 6, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 7, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 8, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
        { 9, new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 } }
    };

    // Delete a value from a particular row's permitted values
    public static void DeleteRowPermittedValue(int row, int value) { row_PermittedValues[row].Remove(value); }

    // Deletes a value from a particular column's permitted values 
    public static void DeleteColPermittedValue(int col, int value) { column_PermittedValues[col].Remove(value); }

    // Deletes a value from a particular section's permitted values 
    public static void DeleteSectionPermittedValue(int section, int value) { section_PermittedValues[section].Remove(value); }

    // Add a value to a particular row's permitted values 
    public static void AddRowPermittedValue(int row, int value) { row_PermittedValues[row].Add(value); }

    // Add a value to a particular column's permitted values 
    public static void AddColPermittedValue(int col, int value) { column_PermittedValues[col].Add(value); }

    // Add a to from a particular section's permitted values 
    public static void AddSectionPermittedValue(int section, int value) { section_PermittedValues[section].Add(value); }

}
