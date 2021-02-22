﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_handler : MonoBehaviour
{
    // Function to end the game
    public void End_Game()
    {
        Call_Save();
        Disable_player_input();
        Disable_general_ui();
        Explode_player();
        Stop_time();
        ShowAdd();
        Call_End_Screen();
    }

    // Save game
    private void Call_Save(){
        //TODO: Create binding with the save script
    }

    // Disable user input
    private void Disable_player_input(){
        //TODO: Call user input disable routine
    }

    // Disable general UI
    private void Disable_general_ui(){
        //TODO: Call disable ui routine
    }

    // Change Player sprite to explosion
    private void Explode_player(){
        //TODO: Call player change sprite
    }

    // Stop time in a good manner
    private void Stop_time(){
        //TODO: Create gradual time shift to zero
    }

    // Show Intersticial add
    private void ShowAdd(){
        //TODO: Implement the add 
    }

    // Show End screen menu
    private void Call_End_Screen(){
        //TODO: Implement the end screen menu
    }

}