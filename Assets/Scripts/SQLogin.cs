using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SQLogin : MonoBehaviour {

    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public Button LoginButton;

    // Start is called before the first frame update
    void Start() {
        LoginButton.onClick.AddListener(() => {
            StartCoroutine(SQMain.Instance.SQWeb.SQLogin(UsernameInput.text, PasswordInput.text));
        });
    }


}
