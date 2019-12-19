using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerEnemyCollision : MonoBehaviour
{
	 public Animator anim;
	 public Component player;
	 public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
          anim = GetComponent<Animator>();
          player = GetComponent("PlayerController");
          rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
  void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy") {
            anim.Play("playerDeath");
            Behaviour bhvr = (Behaviour)player;
            bhvr.enabled = false; 
            rb.isKinematic = true;
        }
                
    }
}
