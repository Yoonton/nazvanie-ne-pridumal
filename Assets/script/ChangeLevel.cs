using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] GameObject platform1;
    [SerializeField] GameObject platform2;
    private bool chg = true;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            platform1.SetActive(chg);
            platform2.SetActive(!chg);
            chg = !chg;
        }
    }
}
