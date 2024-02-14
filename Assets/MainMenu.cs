using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;




public class MainMenu : MonoBehaviour
{
    private string gameMode;


    public TMPro.TMP_Dropdown m_Dropdown;
    private string currentPoseName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(m_Dropdown.value);
    }

    public static void onStartButtonClick()
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }
}
