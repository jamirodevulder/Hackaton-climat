﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckToren : MonoBehaviour {
    public string torentje;
    // Use this for initialization
    void Start () {
		
	}
   
    // Update is called once per frame
    void Update () {
		
	}
    public void OnPointerClick(PointerEventData eventData)
    {
        print("test");
        torentje = "toren1";
    }
}
