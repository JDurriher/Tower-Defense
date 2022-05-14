using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()      // Method called when button clicked
    {
        Debug.Log("stndrd turret");
        buildManager.SelectTurretToBuild(standardTurret);   // Calls method on build manager and we pass in turret that corresponds to this button
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("missile launcher");
        buildManager.SelectTurretToBuild(missileLauncher);

    }

    public void SelectLaserBeamer()
    {
        Debug.Log("laz0r bemmer ");
        buildManager.SelectTurretToBuild(laserBeamer);

    }
}
