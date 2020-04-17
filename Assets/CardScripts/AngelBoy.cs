using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AngelBoy", menuName = "AngelBoy Card")]
public class AngelBoy : Card
{
    public override void onPlay(){
        attack+=1;
        Debug.Log("Angel Boy was Played");
    }
}
