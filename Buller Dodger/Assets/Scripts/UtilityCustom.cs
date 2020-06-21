
using UnityEngine;


public class UtilityCustom 
{
    private static float x;
    private static float z;
    private static string side;


    public static Vector3 GetRandomPosition()
    {
        int rand = Random.Range(0, Main.EnemyMain.globalRefs.sidesRelativeToScreen.Length);        
        
        side = Main.EnemyMain.globalRefs.sidesRelativeToScreen[rand];
        if (side == "West")
        {
            x = Main.EnemyMain.globalRefs.west.x;
            z = Random.Range(-Main.EnemyMain.globalRefs.west.y, Main.EnemyMain.globalRefs.west.y);
        }
        else if (side == "East")
        {
            x = Main.EnemyMain.globalRefs.east.x;
            z = Random.Range(-Main.EnemyMain.globalRefs.east.y, Main.EnemyMain.globalRefs.east.y);
        }
        else
        {
            x = Random.Range(-Main.EnemyMain.globalRefs.north.x,Main.EnemyMain.globalRefs.north.x);
            z = Main.EnemyMain.globalRefs.north.y;
        }
        return new Vector3(x, 0.5f, z);

    }

    public static Vector3 GetDestination()
    {
        if (side == "West")
        {
            x = Main.EnemyMain.globalRefs.east.x;
            z = Random.Range(-Main.EnemyMain.globalRefs.east.y, Main.EnemyMain.globalRefs.east.y);
            
        }
        else if (side == "East")
        {
            x = Main.EnemyMain.globalRefs.west.x;
            z = Random.Range(-Main.EnemyMain.globalRefs.west.y, Main.EnemyMain.globalRefs.west.y);
        }
        else
        {
            x = Random.Range(-Main.EnemyMain.globalRefs.north.x, Main.EnemyMain.globalRefs.north.x);
            z = -Main.EnemyMain.globalRefs.north.y;
        }
        return new Vector3(x, 0.5f, z);

    }
   
}
