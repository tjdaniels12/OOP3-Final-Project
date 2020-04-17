using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawHand : MonoBehaviour
{
    public GameObject Card;
    public HorizontalLayoutGroup Hand;
    public Deck Deck;


    // Start is called before the first frame update
    void Start()
    {
        Deck.DrawCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
