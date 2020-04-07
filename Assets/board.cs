//OOP4200-02
//Hearthstone Final Project
//Group 5
//Levi Willms, Tyler Daniels, Alex Anderson, Joshua Morand
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board
{

    public int turnCounter = 0;
    public const int MANA_INCREASE_PER_TURN = 1;

    public Button btnEndTurn;

    //gameState boolean to determine if there is a game started
    //false if the game hasn't started or is over, true if the game is on
    public bool gameState = false;

    //boolean to determine who's turn it is, when the player finishes
    //their turn. It is set to false
    public bool yourTurn = true;

    /// <summary>
    /// Default Constructor for the board object
    /// </summary>
    /// <param name="playerOneMana"></param>
    /// <param name="playerOneHealth"></param>
    /// <param name="playerOneDeck"></param>
    /// <param name="playerTwoMana"></param>
    /// <param name="playerTwoHealth"></param>
    /// <param name="playerTwoDeck"></param>
    public Board(int playerOneMana = 0, int playerOneHealth = 30,  int playerTwoMana = 0, int playerTwoHealth = 30,  bool yourTurn = true, Deck playerOneDeck = null, Deck playerTwoDeck = null) { }

    /// <summary>
    /// Property to set/get/store whos turn the game is currently on
    /// </summary>
    protected bool whosTurn;
    public bool WhosTurn
    {
        set
        {
            whosTurn = value;

        }
        get
        {
            return whosTurn;
        }
    }


}