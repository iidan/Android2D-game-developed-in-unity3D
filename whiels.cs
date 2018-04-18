using UnityEngine;
using System.Collections;

public class whiels : MonoBehaviour {

    public Animator anim;

    void OnCollisionStay2D(Collision2D other)
    {
        anim.SetBool("touchTheGround", true);
    }

    void OnCollisionExit2D(Collision2D other)
    {
        anim.SetBool("touchTheGround", false);
    }

}
