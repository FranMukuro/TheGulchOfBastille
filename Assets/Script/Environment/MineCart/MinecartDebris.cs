﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinecartDebris : MonoBehaviour
{
    [SerializeField]
    private Vector2 minecartImpulse = new Vector2(2, 0);

    public bool isDebris = true;
    public Player player;

    void OnEnable() {
        if(!isDebris){
            return;
        }
        
        if(!MiscData.gateOpened.ContainsKey(GetComponent<GulchGUID>().ID)){
            MiscData.gateOpened.Add(GetComponent<GulchGUID>().ID, false);
        }

        if(MiscData.gateOpened[GetComponent<GulchGUID>().ID]){
            GetComponent<Collider2D>().enabled = false;
            GetComponentInChildren<Animator>()?.Play(AnimationHash.DebrisAnimationHash.Debris_Broken);
        }
        else{
            GetComponent<Collider2D>().enabled = true;
            GetComponentInChildren<Animator>()?.Play(AnimationHash.DebrisAnimationHash.Debris_Unbreak);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.GetComponent<Minecart>() != null){
            bool isFromLeft = other.collider.transform.position.x - transform.position.x < 0;
            other.collider.GetComponent<Rigidbody2D>()?.AddForce(new Vector2(minecartImpulse.x * (isFromLeft?-1:1), minecartImpulse.y), ForceMode2D.Impulse);

            if(isDebris){
                GetComponent<Collider2D>().enabled = false;
                GetComponentInChildren<Animator>()?.Play(AnimationHash.DebrisAnimationHash.Debris_Break);
                if(!MiscData.gateOpened.ContainsKey(GetComponent<GulchGUID>().ID)){
                    MiscData.gateOpened.Add(GetComponent<GulchGUID>().ID, true);
                }
                else{
                    MiscData.gateOpened[GetComponent<GulchGUID>().ID] = true;
                }
            }

        }
    }
}
