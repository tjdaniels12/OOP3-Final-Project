using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Theo", menuName = "Theo Card")]
public class Theo : Card
{
    public override void onPlay(){
        attack+=3;
    }
}
