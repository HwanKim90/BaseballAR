using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{
    enum PitcherState
    {
        Idle,
        Pitch
    }

    PitcherState state;

    Transform player;

    Animator anim;

    public GameObject pitching;
    public GameObject ballFactory;

    bool isPitching;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case PitcherState.Idle:
                Idle();
                break;
            case PitcherState.Pitch:
                Pitch();
                break;
        }
    }
    public void OnClickPitch()
    {
        isPitching = true;
    }

    void Idle()
    {
        if(isPitching == true)
        {
            state = PitcherState.Pitch;
            print("상태전환 : Idle -> Pitch");
            anim.SetTrigger("Pitch");
        }
    }

    

    void Pitch()
    {
        state = PitcherState.Idle;
        anim.SetTrigger("Idle");
        isPitching = false;

    }
}
