﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFadeout : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Image>().color = new Color(255, 255, 255, GetComponent<Image>().color.a - 0.03f);
        if (GetComponent<Image>().color.a < 0)
            gameObject.SetActive(false);
    }
}
