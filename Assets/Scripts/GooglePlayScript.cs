﻿using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.UI;

public class GooglePlayScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
        SingIn();

    }

    void SingIn() {
       
        if (!PlayGamesPlatform.Instance.localUser.authenticated)
        {
            PlayGamesPlatform.Instance.Authenticate((bool success) => {
                if (success)
                {
                    /// Signed in! Hooray!
                }
                else
                {
                    /// Not signed in. We'll want to show a sign in button
                }
            }, true);   /// <--- That "true" is very important!
        }
        else
        {
            Debug.Log("We're already signed in");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
