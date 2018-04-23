using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    bool firing = true;
    bool cooldown = true;

    private void Update()
    {
        if(firing && !cooldown)
        {

            print("YES");

            if (!cooldown)
                cooldown = true;
        }
        else if(cooldown || !firing)
        {
            print("N0");

            if (cooldown)
                cooldown = false;
        }
        else if(!firing)
        {

            print("Maybe");
        }
    }
}
