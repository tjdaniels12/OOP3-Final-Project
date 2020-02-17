using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public GameObject Card;
    public HorizontalLayoutGroup Hand;

    // Start is called before the first frame update
    void Start()
    {
        
        //this.transform.position = this.transform.position + new Vector3(3, 0);
        var go = Instantiate(Card, new Vector3(0, 0), Quaternion.identity);
        go.transform.SetParent(Hand.transform);
        CardDisplay display = go.GetComponent<CardDisplay>();
        //display.name = "TestName";
        //display.descriptionText.text = "TestDescription";
        display.card = Resources.Load<Card>("dug");
        Debug.Log(display.card.name);
        //AddComponent<ScriptableObject> blah;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
