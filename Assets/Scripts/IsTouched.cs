using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouched : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        print("working enter");
        anim.SetBool("touching", true);
    }

    private void OnTriggerStay(Collider collision)
    {
        print("working stay");
        anim.SetBool("touching", true);
    }

    private void OnTriggerExit(Collider collision)
    {
        print("working exit");
        anim.SetBool("touching", false);
    }
}
