﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTable : MonoBehaviour {

    private void OnMouseDown()
    {
        GameObject sceneMaster = GameObject.FindGameObjectWithTag("SceneMaster");
        sceneMaster.GetComponent<SceneMasterScript>().SetConditionsState(false);
    }
}