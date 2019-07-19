using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool destroyed { get; private set; }
    public bool isBuilt { get; private set; } = false;
    public Building building { get; private set; }
    private Street street;

    public void SetStreet(Street street) => this.street = street;
}
