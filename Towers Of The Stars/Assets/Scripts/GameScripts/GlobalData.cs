using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData
{

    /* Static makes it so your points and cloud coins follow you to every scene */


    //Currency
    public static int PlayerPoint;
    public static int CloudCoins;

    //spire stats
    public static int SpireHealth = 100;

    //Tower selection
    public static GameObject SelectedTower;
    public static List<GameObject> TowerList = new List<GameObject>();

}
