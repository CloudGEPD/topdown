using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int max_ammo;
    public float fire_frequency;
    public float reloadtime;

    private int current_ammo;
    private bool reloading;

    bool cooldown;
    
    void Start()
    {
        Reload();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0) && !cooldown && current_ammo > 0)
        {
            current_ammo = current_ammo - 1;
            cooldown = true;
            print(current_ammo);
            StartCoroutine(FireFrequency());
        }
        else if (current_ammo <= 0 && !reloading )
        {
            reloading = true;
            StartCoroutine(Reloading());

        }
    }
    
    IEnumerator FireFrequency()
    {
        yield return new WaitForSeconds(fire_frequency);
        cooldown = false;
    }
    IEnumerator Reloading()
    {
        print("......");
         yield return new WaitForSeconds(reloadtime);
        Reload();
        reloading = false;
    }


    void Reload()
    {
        current_ammo = max_ammo;

    }
}
