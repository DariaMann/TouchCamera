using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GUITileController : MonoBehaviour
{
    [SerializeField] private List<GUITile> tiles;
    [SerializeField] private GameObject tilePrefab;

    private void Start()
    {
        foreach (var tile in tiles)
        {
            tile.SetData(this);
        }
    }

    public void AddTile(Transform tileTap)
    {
        GameObject tile = Instantiate(tilePrefab,
            new Vector3(tileTap.position.x, tileTap.position.y + 1.1f, tileTap.position.z), new Quaternion());
        GUITile guiTile = tile.GetComponent<GUITile>();
        guiTile.SetData(this);
        tiles.Add(guiTile);
    }
}
