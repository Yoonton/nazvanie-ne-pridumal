using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] GameObject platform1;
    [SerializeField] GameObject platform2;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            platform1.SetActive(true);
            platform2.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            platform2.SetActive(true);
            platform1.SetActive(false);
        }
    }
}
