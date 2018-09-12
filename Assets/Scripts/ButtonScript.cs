using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    public Button button;
	public GodScript god;
	public Sprite paussed;
	public Sprite notPaussed;
	// Use this for initialization
	void Start () {
		button = GetComponent<Button>();
		button.onClick.AddListener(clicked);
	}

	void clicked(){
		god.pausUnpause();
	}
	
	// Update is called once per frame
	void Update () {
		if(god.getPauseStatus()){
			button.image.sprite = paussed;
		}else{
			button.image.sprite = notPaussed;
		}
	}
}
