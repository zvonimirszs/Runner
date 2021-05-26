using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwither : MonoBehaviour
{

    [SerializeField] int currentWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetWeaponAcitive();
    }

    // Update is called once per frame
    void Update()
    {
        int previosWeapon = currentWeapon;

        ProcessKeyInput();
        ProcessScrollWheel();

        if(previosWeapon != currentWeapon)
        {
            SetWeaponAcitive();
        }
    }

    private void ProcessKeyInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
    }

    private void ProcessScrollWheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(currentWeapon >= transform.childCount -1)
            {
                currentWeapon = 0;
            }
            else
            {
                currentWeapon++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentWeapon <= 0)
            {
                currentWeapon = transform.childCount - 1;
            }
            else
            {
                currentWeapon--;
            }
        }
        //Mouse ScrollWheel
    }

    private void SetWeaponAcitive()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform)
        {
            if(weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else 
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }


}
