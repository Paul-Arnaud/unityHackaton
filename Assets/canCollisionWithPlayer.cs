using UnityEngine;


public class canCollisionWithPlayer : MonoBehaviour
{
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log(anim);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") {
            anim.Play("canCrush");
        }
                
    }
}