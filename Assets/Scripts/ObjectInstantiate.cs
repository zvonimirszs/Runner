using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiate : MonoBehaviour
{
    [SerializeField] GameObject battery;
    [SerializeField] GameObject bullets;
    [SerializeField] GameObject shells;
    [SerializeField] GameObject locker;

    [SerializeField] GameObject enemy;

    void Awake()
    {
        #region battery
        Instantiate(battery, new Vector3(9.5f, 45f, 21.5f), Quaternion.identity);
        Instantiate(battery, new Vector3(23.84f, 45f, 31.71f), Quaternion.identity);
        Instantiate(battery, new Vector3(85.61f, 45f, 93.57f), Quaternion.identity);
        Instantiate(battery, new Vector3(92.72f, 45f, 31f), Quaternion.identity);
        Instantiate(battery, new Vector3(89f, 45f, -8f), Quaternion.identity);
        #endregion

        #region shells
        Instantiate(shells, new Vector3(31f, 45f, 29.78f), Quaternion.identity);
        Instantiate(shells, new Vector3(96.68f, 45f, 97.27f), Quaternion.identity);
        #endregion

        #region bullets
        Instantiate(bullets, new Vector3(21.60162f, 46f, 30.27f), Quaternion.identity);
        Instantiate(bullets, new Vector3(89.68f, 45.5f, 92.45f), Quaternion.identity);
        Instantiate(bullets, new Vector3(103f, 45.5f, 27.65f), Quaternion.identity);
        #endregion

        #region locker
        Instantiate(locker, new Vector3(-10.14f, 41.35f, -17.10f), Quaternion.identity);
        #endregion

        #region enemy
        Instantiate(enemy, new Vector3(95f, 45.5f, 92.45f), Quaternion.identity);
        Instantiate(enemy, new Vector3(59f, 45.5f, 43f), Quaternion.identity);
        Instantiate(enemy, new Vector3(51f, 45.5f, 53f), Quaternion.identity);
        Instantiate(enemy, new Vector3(82f, 45.5f, 48f), Quaternion.identity);
        Instantiate(enemy, new Vector3(105f, 45.5f, 12f), Quaternion.identity);
        #endregion

        
    }
}
