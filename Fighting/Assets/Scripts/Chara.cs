using UnityEngine;
using System.Collections;

public class Chara : MonoBehaviour
{
    private Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
	
	}

    void OnCollisionEnter()
    {
        anim.SetBool("DamageDown", true);
    }
}
