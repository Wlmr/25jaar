using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour {

    public Text passwordHolder;
    public Image startImage;
    public InputField inputfield;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void registerPassword() {
        PlayerPrefs.SetString("password", gameObject.GetComponent<InputField>().text);
        passwordHolder.text = PlayerPrefs.GetString("password");
        startImage.gameObject.SetActive(false);
        inputfield.gameObject.SetActive(false);

    }
}
