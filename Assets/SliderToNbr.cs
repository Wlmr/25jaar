using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderToNbr : MonoBehaviour {

    public Slider target;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = ""+target.value;
	}
	
	// Update is called once per frame
	public void Updatera () {
        if (target.value != 26) {
            gameObject.GetComponent<Text>().text = "" + target.value;
        }
        
        
    }
}
