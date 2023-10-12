using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ButtonManager : MonoBehaviour
{
    public Button proceedButton;

    private void Start()
    {
        // Disable the ProceedButton initially.
        proceedButton.gameObject.SetActive(false);

        //// Add click listeners to the buttons.
        //selectionButton.onClick.AddListener(OnSelectionButtonClick);
        //selectionButton1.onClick.AddListener(OnSelectionButton1);
        //proceedButton.onClick.AddListener(OnProceedButtonClick);
    }
    int selectedIntensity;
    public void OnSelectionButtonClick(int intensity)
    {
        // Put your code here for what should happen when the SelectionButton is clicked.
        selectedIntensity = intensity;
        // For example, you can enable the ProceedButton.
        proceedButton.gameObject.SetActive(true);
    }



    public void OnProceedButtonClick()
    {
        //// Put your code here for what should happen when the ProceedButton is clicked.

        //// For example, you can load a new scene or perform some action.
        //SceneManager.LoadScene("FirstMagnitudeLvl");
        ////SceneManager.LoadScene("SecondMagnitudeLvl");
        ///

        if (selectedIntensity == 1)
        {
            SceneManager.LoadScene("FirstMagnitudeLvl");
        }
        else if (selectedIntensity == 2)
        {
            SceneManager.LoadScene("SecondMagnitudeLvl");
        }

        else if (selectedIntensity == 3)
        {
            SceneManager.LoadScene("ThirdMagnitudeLvl");
        }

        else if (selectedIntensity == 4)
        {
            SceneManager.LoadScene("FourthMagnitudeLvl");
        }

        else if (selectedIntensity == 5)
        {
            SceneManager.LoadScene("FifthMagnitudeLvl");
        }

        else if (selectedIntensity == 6)
        {
            SceneManager.LoadScene("SixthMagnitudeLvl"); 
        }
    }
}
