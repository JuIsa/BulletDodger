using UnityEngine;
using System.Collections;
using System;

[CreateAssetMenu(fileName = "GlobalRefs", menuName = "ScriptableObjects/GlobalRefs")]
public class GlobalRefs : ScriptableObject
{
    public string[] sidesRelativeToScreen = new string[] { "East", "West", "North"};
    public Vector2 west;
    public Vector2 east;
    public Vector2 north;
    public GameObject westWall;
    public GameObject eastWall;
    public GameObject northWall;
    public GameObject southWall;



}
