using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class SQWeb : MonoBehaviour
{
    //public SQRegisterUser setInfo;
    void Start() 
    {
        //StartCoroutine(SQGetUsers());
        //StartCoroutine(SQLogin("squser", "123456"));
        //StartCoroutine(SQRegisterUser("squser3", "123456"));
    }

    IEnumerator GetDate() {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/SurviQuakeBackend/GetDate.php")) 
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else 
            {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator SQGetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/SurviQuakeBackend/SQGetUsers.php")) 
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
    }

    public IEnumerator SQLogin(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("sqLoginUser", username);
        form.AddField("sqLoginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SurviQuakeBackend/SQLogin.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                if(www.downloadHandler.text.Contains("Wrong Credentials") || www.downloadHandler.text.Contains("Username does not exists"))
                {
                    Debug.Log("Try Again");
                }
                else
                {
                    //If we logged in correctly
                    SceneManager.LoadScene("MainMenu");
                }

            }
        }
    }

    public IEnumerator SQRegisterUser(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("sqLoginUser", username);
        form.AddField("sqLoginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SurviQuakeBackend/SQRegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                Debug.Log(responseText);
                //setInfo.info.text = responseText;
            }
        }
    }
}

