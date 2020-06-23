using UnityEngine;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;

public class RayManager 
{
    private static List<Ray> rays = new List<Ray>();
    private static List<Vector3> hitPoints = new List<Vector3>();
    private static List<Vector3> positionsForWalls = new List<Vector3>();

    public static void StartRays()
    {
        GenerateRays();
        GetHitPoint();
        DrawRaysFromCorners();
        CalculateMiddlePoints();
        GenerateWalls();
    }

    private static void GenerateWalls()
    {
        GameObject.Instantiate(Main.EnemyMain.globalRefs.northWall, positionsForWalls[0], Quaternion.identity);
        Debug.Log("north");
        GameObject.Instantiate(Main.EnemyMain.globalRefs.westWall, positionsForWalls[1], Quaternion.identity);
        Debug.Log("west");
        GameObject.Instantiate(Main.EnemyMain.globalRefs.southWall, positionsForWalls[2], Quaternion.identity);
        Debug.Log("south");
        GameObject.Instantiate(Main.EnemyMain.globalRefs.eastWall, positionsForWalls[3], Quaternion.identity);
        Debug.Log("eats");
    }

    private static void CalculateMiddlePoints()
    {
        Vector3 north = new Vector3(0f, hitPoints[0].y, hitPoints[0].z-.5f);
        Vector3 west = new Vector3(hitPoints[1].x-.5f, hitPoints[1].y, 0f);
        Vector3 south = new Vector3(0f, hitPoints[2].y, hitPoints[2].z+.5f);
        Vector3 east = new Vector3(hitPoints[3].x+.5f, hitPoints[3].y, 0f);
        positionsForWalls.Add(north);
        positionsForWalls.Add(west);
        positionsForWalls.Add(south);
        positionsForWalls.Add(east);
    }

    private static void GetHitPoint()
    {
        RaycastHit hit;
        foreach (var ray in rays)
        {
            Physics.Raycast(ray, out hit);
            Vector3 hitPoint = hit.point;
            hitPoints.Add(hitPoint);
        }
    }

    private static void GenerateRays()
    {
        
        Ray topLeft = Camera.main.ViewportPointToRay(new Vector3(0f, 0f, 0f));
        Ray topRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, 0, 0));
        Ray botRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, Screen.height, 0));
        Ray botLeft = Camera.main.ScreenPointToRay(new Vector3(0, Screen.height, 0));
        
        rays.Add(topRight);
        rays.Add(topLeft);
        rays.Add(botLeft);
        rays.Add(botRight);
        
    }

    public static void DrawRaysFromCorners()
    {
        foreach (var point in hitPoints)
            Debug.DrawRay(point, new Vector3(.0f, 2f, .0f), Color.blue, 20f);
    }

    public static Vector3 GetPointBetween(Vector3 one, Vector3 two)
    {
        
        if (one.x != two.x)
            return new Vector3(0f, one.y, one.z);
        else if (one.z != two.z)
            return new Vector3(one.x, one.y, 0f);
        else
            return Vector3.one;
    }

}
