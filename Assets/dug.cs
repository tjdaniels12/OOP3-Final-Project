using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dug", menuName = "Dug Card")]
public class dug : Card
{
    public override void onPlay(){
        health=health+1;
        Debug.Log("DUG WAS PLAYED");
        }
}
