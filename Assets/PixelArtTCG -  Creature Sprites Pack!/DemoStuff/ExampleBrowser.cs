using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleBrowser : MonoBehaviour {
	public List<Sprite> list;
	public GameObject content;
	public GameObject CardImagePrefab;
	// Use this for initialization
	void Start () {

		foreach (Sprite spr in list){
			GameObject currentobj = Instantiate (CardImagePrefab, content.transform);
			currentobj.GetComponent<Image> ().sprite = spr;

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
