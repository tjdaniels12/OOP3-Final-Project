using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[CreateAssetMenu(fileName = "Doppler", menuName = "Doppler Card")]
public class Doppler : Card
{
    
    public GameObject Card;
    public GameObject sisterCard;

    public override void onPlay(){
        Debug.Log("on play triggered");
        Card uniqueDoppler = Object.Instantiate(this);

        var go = Instantiate(Card, new Vector3(0, 0), Quaternion.identity);
        go.transform.SetParent(sisterCard.transform.parent);

        CardDisplay display = go.GetComponent<CardDisplay>();
        display.card = uniqueDoppler;
    }
}