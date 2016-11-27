using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public ParticleSystem fireworks;
    private int counter;
    public Text secretText;
    public AudioSource song;

	// Use this for initialization
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if(gameObject.GetComponent<Slider>().value == 25) {
            fireworks.gameObject.SetActive(true);
            song.gameObject.SetActive(true);

        }
        if(counter > 5) {
            secretText.gameObject.SetActive(true);
        }
	}

    public void buttonPress() {
        counter++;
    }
}
