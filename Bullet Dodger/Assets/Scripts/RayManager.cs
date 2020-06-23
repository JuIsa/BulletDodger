using UnityEngine;
using System.Collections.Generic;

public class RayManager 
{ 

    public static void DrawRaysFromCorners()
    {
        List<Ray> rays = new List<Ray>();
        RaycastHit hit;
        Ray topLeft = Camera.main.ViewportPointToRay(new Vector3(0f, 0f, 0f));
        Ray topRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, 0, 0));
        Ray botRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, Screen.height, 0));
        Ray botLeft = Camera.main.ScreenPointToRay(new Vector3(0, Screen.height, 0));

        rays.Add(topLeft);
        rays.Add(topRight);
        rays.Add(botLeft);
        rays.Add(botRight);

        foreach (var ray in rays)
        {
            Physics.Raycast(ray, out hit);
            Vector3 hitPoint = hit.point;
            Debug.DrawRay(hitPoint, new Vector3(.0f, 2f, .0f), Color.blue, 20f);
        }
        
    } 
}
