using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]

public class Card : ScriptableObject{
    public new string name;
    public string description;

    public Sprite artwork;
    public int manaCost;
    public int attack;
    public int health;
    
    public delegate void onPlay();
    public onPlay Playing;


    [SerializeField]
    private int baseMana;
    [SerializeField]
    private int baseAttack;
    [SerializeField]
    private int baseHealth;

    //public void inPlay(){Playing();}

    public int getBaseAttack(){ return baseAttack;}
    public int getBaseHealth(){ return baseHealth;}
    public int getBaseMana(){ return baseMana;}


}
