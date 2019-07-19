using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : SingletonMonobehavior<MapManager>
{
    public List<Street> map = new List<Street>();

    [SerializeField] private Street street1;
    [SerializeField] private Street street2;
    [SerializeField] private Street street3;
    [SerializeField] private Street street4;

    void Start()
    {
        map.Add(street1);
        map.Add(street2);
        map.Add(street3);
        map.Add(street4);
    }

    public Street GetStreet(int street)
    {
        return map[street - 1];
    }
}
