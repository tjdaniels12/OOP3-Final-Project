using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    public const float maxWidth = 100f;
    public const float minWidth = 0f;
    public float width = 100f;



    public GameObject Card;
    public Image DeckPic;
    public HorizontalLayoutGroup Hand;

    List<Card> deck = new List<Card>();
    Card card;

   
    void Start()
    {
        //card = Resources.Load<Card>("dug");
        //Card someInstance = ScriptableObject.CreateInstance("dug") as Card;
        Card test = Resources.Load<Card>("dug");
        Card newUniqueSO = Object.Instantiate(test);
        Card test3 = Object.Instantiate(test);
        Card test4 = Object.Instantiate(test);
        deck.Add(newUniqueSO);
        deck.Add(test3);
        deck.Add(test4);


        for(int i =0; i<40;i++){
            newUniqueSO = null;
            newUniqueSO = Object.Instantiate(test);
            deck.Add(newUniqueSO);
        }
        Debug.Log(deck.Count);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");

            DrawCard();
        }

        if (TurnSystem.startTurn == true)
        {
            DrawCard();
            TurnSystem.startTurn = false;
        }
    }

    public void DrawCard()
    {
        if (deck.Count != 0)
        {
           
            if (Hand.transform.childCount < 10)
            {
                var go = Instantiate(Card, new Vector3(0, 0), Quaternion.identity);
                go.transform.SetParent(Hand.transform);


                CardDisplay display = go.GetComponent<CardDisplay>();
                display.card = deck[0];
                deck.RemoveAt(0);
                


                Debug.Log(deck.Count);
                width = (float)deck.Count * 2.5f;
                Debug.Log(width);
                if (width > 100f)
                {
                    width = 100f;
                    Debug.Log("Capped to 40.");
                }
                DeckPic.rectTransform.sizeDelta = new Vector2(width, 100);
                Debug.Log(width);
            }
            
        }
        //else fatigue();
    }

}
