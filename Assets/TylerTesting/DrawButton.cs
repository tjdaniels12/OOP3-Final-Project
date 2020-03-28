using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawButton : MonoBehaviour
{
    public Button drawButton;
    public const float maxWidth = 100f;
    public const float minWidth = 0f;
    public float width = 100f;
    public GameObject Card;
    public Image Deck;
    public HorizontalLayoutGroup Hand;

    List<Card> deck = new List<Card>();
    Card card;


    void Start()
    {
        //card = Resources.Load<Card>("dug");
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        deck.Add(Resources.Load<Card>("dug"));
        deck.Add(Resources.Load<Card>("doggo"));
        Debug.Log(deck.Count);
        Button btn = drawButton.GetComponent<Button>();
        btn.onClick.AddListener(DrawCard);
    }

    void Update()
    {
        
    }

    void DrawCard()
    {
        if (deck.Count != 0)
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
            Deck.rectTransform.sizeDelta = new Vector2(width, 100);
            Debug.Log(width);
        }
    }

}
