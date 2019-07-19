using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] private int up;
    [SerializeField] private int down;
    [SerializeField] private int left;
    [SerializeField] private int right;

    public int currentValue;
    public void CompareWithLeft(Building leftBuilding)
    {
        if (currentValue > 2 * leftBuilding.currentValue)
        {

        }
        else if (currentValue > leftBuilding.currentValue)
        {

        }
        else if (currentValue < leftBuilding.currentValue)
        {

        }
    }
}
