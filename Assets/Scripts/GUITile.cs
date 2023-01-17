using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GUITile : MonoBehaviour, IPointerClickHandler
{
    private GUITileController _tileController;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        _tileController.AddTile(transform);
    }

    public void SetData(GUITileController tileController)
    {
        _tileController = tileController;
    }
}
