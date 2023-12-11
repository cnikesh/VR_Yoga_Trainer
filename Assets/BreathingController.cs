using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreathingController : MonoBehaviour
{
    public GameObject girl;
    public Animator animator;

    public bool part1Complete;

    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        animator = girl.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        part1Complete = animator.GetBool("part1Complete");

        if (part1Complete)
        {
            timer.SetActive(true);
        }
        else
        {
            timer.SetActive(false);
        }
    }
}
