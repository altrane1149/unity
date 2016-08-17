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

    // 他のオブジェクトに接触した時
    void OnCollisionEnter(Collision collision)
    {
        anim.SetBool("DamageDown", true);
    }

    // 他のオブジェクトに接触している間
    void OnCollisionStay(Collision collision)
    {

    }

    // 他のオブジェクトから離れた時
    void OnCollisionExit(Collision collision)
    {
    }
}
