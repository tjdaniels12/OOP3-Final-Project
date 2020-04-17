using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DarkPixi", menuName = "Pixi Card")]
public class DarkPixi : Card
{
    public int buffAmnt = 3;
    public override void onPlay(){
        attack+=buffAmnt;
        Debug.Log("DarkPixi Was Played");
    }
}
