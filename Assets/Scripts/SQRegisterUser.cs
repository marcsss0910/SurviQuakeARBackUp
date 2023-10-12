using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SQRegisterUser : MonoBehaviour {
    
    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public Button RegisterButton;
    public TMP_Text info;

    public GameObject regisloginPopup;

    // Start is called before the first frame update
    void Start() {
        RegisterButton.onClick.AddListener(() => {
            StartCoroutine(SQMain.Instance.SQWeb.SQRegisterUser(UsernameInput.text, PasswordInput.text));
        });
    }

    public void whenButtonClick()
    {
        if (regisloginPopup.activeInHierarchy == true)
            regisloginPopup.SetActive(false);
        else
            regisloginPopup.SetActive(true);
    }
    

}
