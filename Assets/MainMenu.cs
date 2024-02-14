using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;




public class MainMenu : MonoBehaviour
{
    private string gameMode;

    [System.Serializable]
    public Dropdown m_Dropdown
    private string currentPoseName;
    // Start is called before the first frame update
    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the current index of the Dropdown in a variable
        m_DropdownValue = m_Dropdown.value;
        //Change the message to say the name of the current Dropdown selection using the value
        Console.Log(m_Dropdown.options[m_DropdownValue].text);
    }

    public static void onStartButtonClick()
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }
}
