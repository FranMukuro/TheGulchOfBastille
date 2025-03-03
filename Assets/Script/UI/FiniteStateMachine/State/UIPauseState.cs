﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPauseState : UIState
{
    private ButtonGroup buttonGroup;
    private enum Selection{
        Save, Equipment, Inventory, Options, Exit,
    };
    public UIPauseState(UIHandler uiHandler, GameObject parentNode, ButtonGroup buttonGroup): base(uiHandler, parentNode)
    {
        this.buttonGroup = buttonGroup;
    }

    public override void Enter()
    {
        base.Enter();
        Time.timeScale = 0f;
    }

    public override void Exit()
    {
        base.Exit();
        Time.timeScale = 1;
    }

    public override void Update()
    {
        base.Update();
    }

    public override void OnInteraction()
    {
        UIStateEventData data;
        data.index = buttonGroup.GetIndexOfCurrentSelected();
        data.widgetType = UIState.WidgetType.Button;
        OnClick(data);
    }

    public override void OnClick(UIStateEventData eventData){
        switch((Selection)eventData.index){
            case Selection.Save:
                uiHandler.uiFSM.PushState(uiHandler.uiSaveState);
                Time.timeScale = 0.0f;
                break;
            case Selection.Equipment:
                uiHandler.uiFSM.PushState(uiHandler.uiEquipmentState);
                break;
            case Selection.Inventory:
                uiHandler.uiFSM.PushState(uiHandler.uiInventoryState);
            break;
            case Selection.Options:
            break;
            case Selection.Exit:
                uiHandler.GM.ExitGame();
            break;
            default:
            break;
        }

    }

}
