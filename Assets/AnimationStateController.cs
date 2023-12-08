using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator;
    int isTalkingHash;
    float talkBlendRate = 0.0f;
    int talkingAnimationBlendHash;
    bool talkBlendRateIncrease = false;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        isTalkingHash = Animator.StringToHash("isTalking");
        talkingAnimationBlendHash = Animator.StringToHash("TalkAnimationBlend");



    }

    // Update is called once per frame
    void Update()
    {

        talkBlendAnimation();
    }

    void talkBlendAnimation() {

        bool isTalking = animator.GetBool(isTalkingHash);


        bool spacebarPress = Input.GetKey("space");

        if (!isTalking && spacebarPress)
        {
            animator.SetBool(isTalkingHash, true);
        }

        if (isTalking && spacebarPress)
        {
            animator.SetBool(isTalkingHash, false);
        }

        if (isTalking)
        {

            if (talkBlendRate < 0)
            {

                talkBlendRateIncrease = true;

            }
            if (talkBlendRate > 1.5)
            {
                talkBlendRateIncrease = false;
            }

            if (talkBlendRateIncrease)
            {
                talkBlendRate += 0.001f;
            }
            else
            {
                talkBlendRate -= 0.0001f;
            }


            animator.SetFloat(talkingAnimationBlendHash, talkBlendRate);
        }
    }
}
