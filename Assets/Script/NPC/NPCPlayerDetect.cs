﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPlayerDetect : MonoBehaviour
{
    private NPCEventHandler npcEventHandler;
    private NPC npc;

    void Start()
    {
        npcEventHandler = GetComponent<NPCEventHandler>();
        npc = GetComponentInParent<NPC>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            npc.npcConversationHandler.gameObject.SetActive(true);
            npcEventHandler.OnNPCEnterInteraction();
            var player = collider.gameObject.GetComponent<Player>();
            player.SetNPCEventHandler(npcEventHandler);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            npcEventHandler.OnNPCExitInteraction();
            collider.gameObject.GetComponent<Player>().SetNPCEventHandler(null);
            npc.npcConversationHandler.gameObject.SetActive(false);
        }
    }

}
