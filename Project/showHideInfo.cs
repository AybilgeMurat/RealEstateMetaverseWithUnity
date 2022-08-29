using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class showHideInfo : MonoBehaviour
{
    public GameObject InfoObject;
    private bool show = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowandHideInfo()
    {
        if (!show)
        {
            InfoObject.SetActive(true);
            show = true;
        }
        else { InfoObject.SetActive(false);
            show = false;
        }

    }

}