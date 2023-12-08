using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using TMPro;
using System;
using System.IO;
using System.Linq;

public class PoseInstructions : MonoBehaviour
{
    public GameObject scoreText;
    public TextMeshProUGUI text;
    //public TextAsset jsonData;
    PoseData poseData = new PoseData();

    public bool part1Complete;

    public GameObject girl;
    public Animator animator;
    public class PoseData {
        public string pose_name;
        public int score;
        public int[] angles;
        public string[] steps;

    }
    public string lockFilePath = "C:\\Users\\nikes\\OneDrive\\Documents\\yogatrainer-main\\lock.txt";

    public string jsonFilePath = "C:\\Users\\nikes\\OneDrive\\Documents\\GitHub\\YogaSimple\\Assets\\Json\\Pose_Data.json";

    public float updateInterval = 2.0f; // Update every 2 seconds (adjust as needed)

    private float lastUpdateTime = 0;




    // Start is called before the first frame update
    void Start()
    {
        LoadJSONData();

        text = scoreText.GetComponent<TextMeshProUGUI>();

        animator = girl.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        int poseFlag = 0;

        part1Complete = animator.GetBool("part1Complete");
        

        // Check if it's time to update the JSON data
        if (Time.time - lastUpdateTime >= updateInterval)
        {
            LoadJSONData();
        }

        // Access and use the JSON data as needed
        if (poseData != null)
        {
            string stepText = "";

            for (int i = 8; i < poseData.steps.Length; i++)
            {
                if (poseData.steps[i] != "")
                {
                    stepText += poseData.steps[i] + "\n";
                    poseFlag++;
                }                
            }

            if (poseFlag > 0)
            {
                animator.SetBool("part1Complete", false);
                

            }
            else
            {
                animator.SetBool("part1Complete", true);
                for (int i = 0; i < 8; i++)
                {

                    if (poseData.steps[i] != "")
                    {
                        stepText += poseData.steps[i] + "\n";

                    }
                }

            }

            text.text = stepText;




        }

        

        
    }

    private void LoadJSONData()
    {
        // Read the JSON file and deserialize it into your data class
        if (File.Exists(jsonFilePath))
        {
            string jsonText = File.ReadAllText(jsonFilePath);
            poseData = JsonUtility.FromJson<PoseData>(jsonText);
            lastUpdateTime = Time.time;
        }
        else
        {
            Debug.LogError("JSON file not found at path: " + jsonFilePath);
        }
    }


}
