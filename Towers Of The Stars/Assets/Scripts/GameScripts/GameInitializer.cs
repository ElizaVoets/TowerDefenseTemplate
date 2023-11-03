using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalData.CloudCoins = 0;
        GlobalData.PlayerPoint= 0;
        GlobalData.SelectedTower = null;

        SpireData.Health = 100;
    }

}
