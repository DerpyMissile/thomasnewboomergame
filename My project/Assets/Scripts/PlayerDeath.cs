using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag != "Platform"){
            Application.Quit();
            Debug.Log("ded");
        }
    }
}
