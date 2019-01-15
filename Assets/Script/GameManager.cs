﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;             //This script, like MouseLocation, has a public static reference to itself to that other scripts
                                                    //can access it from anywhere without needing to find a reference to it
    [HideInInspector] public bool gamemodePlay;
    [HideInInspector] public bool gamemodeReplay;
    [HideInInspector] public bool gamemodeGhostRace;
    public GameObject car;
    public GameObject ghost;
    public Camera run;
    public Camera replay1;
    public Camera replay2;
    public Camera replay3;
    public Camera replay4;
    public Camera replay5;
    public Camera replay6;
    [HideInInspector]
    public int score = 0;                                  //The player's current score

    void Awake()
    {
       
        if (Instance == null)
            Instance = this;
       
        else if (Instance != this)
            Destroy(this);
    }

    public void PlayRace()
    {
        gamemodePlay = true;
        gamemodeGhostRace = false;
        gamemodeReplay = false;
        Debug.Log("gamemodeplay : "+ gamemodePlay.ToString());
        run.enabled = true;
        replay1.enabled = false;
        replay2.enabled = false;
        replay3.enabled = false;
        replay4.enabled = false;
        replay5.enabled = false;
        replay6.enabled = false;
     }

    public void GhostRace()
    {
        gamemodeGhostRace = true;
        gamemodePlay = false;
        gamemodeReplay = false;
        run.enabled = true;
        replay1.enabled = false;
        replay2.enabled = false;
        replay3.enabled = false;
        replay4.enabled = false;
        replay5.enabled = false;
        replay6.enabled = false;
    }

    public void RePlay()
    {
        gamemodeReplay = true;
        gamemodePlay = false;
        gamemodeGhostRace = false;
        run.enabled = false;
        replay1.enabled = true;
        replay2.enabled = false;
        replay3.enabled = false;
        replay4.enabled = false;
        replay5.enabled = false;
        replay6.enabled = false;
    }

    public void Enable1()
    {
        if (gamemodeReplay)
        {
            run.enabled = false;
            replay1.enabled = true;
            replay2.enabled = false;
            replay3.enabled = false;
            replay4.enabled = false;
            replay5.enabled = false;
            replay6.enabled = false;
        }
    }

    public void Enable2()
    {
        if (gamemodeReplay)
        {
            run.enabled = false;
            replay1.enabled = false;
            replay2.enabled = true;
            replay3.enabled = false;
            replay4.enabled = false;
            replay5.enabled = false;
            replay6.enabled = false;
        }
    }

    public void Enable3()
    {
        if (gamemodeReplay)
        {
            run.enabled = false;
            replay1.enabled = false;
            replay2.enabled = false;
            replay3.enabled = true;
            replay4.enabled = false;
            replay5.enabled = false;
            replay6.enabled = false;
        }
    }

    public void Enable4()
    { if (gamemodeReplay)
        {
            run.enabled = false;
            replay1.enabled = false;
            replay2.enabled = false;
            replay3.enabled = false;
            replay4.enabled = true;
            replay5.enabled = false;
            replay6.enabled = false;
        }
    }

    public void Enable5()
    { if (gamemodeReplay)
        {
            run.enabled = false;
            replay1.enabled = false;
            replay2.enabled = true;
            replay3.enabled = false;
            replay4.enabled = false;
            replay5.enabled = true;
            replay6.enabled = false;
        }
    }
    public void Enable6()
    {
        if (gamemodeReplay)
        {
            run.enabled = false;
            replay1.enabled = false;
            replay2.enabled = true;
            replay3.enabled = false;
            replay4.enabled = false;
            replay5.enabled = false;
            replay6.enabled = true;
        }
    }
}
