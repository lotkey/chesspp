using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// Class to manage the tiles of a tilemap.
/// </summary>
public class TilemapManager
{
    protected Tilemap m_tilemap;
    protected GridLayout m_gridLayout = null;
    Dictionary<Vector2Int, Sprite> m_setTiles;

    /// <summary>
    /// Create a TilemapManager from a tag.
    /// </summary>
    /// <param name="tag">Tag of the tilemap in the scene</param>
    public TilemapManager(string tag)
    {
        m_setTiles = new Dictionary<Vector2Int, Sprite>();

        m_tilemap = GameObject.FindGameObjectWithTag(tag).GetComponent<Tilemap>();
        m_gridLayout = GameObject.FindObjectOfType<GridLayout>();
        if (m_tilemap is null)
            Debug.LogError($"Cannot find tilemap with tag \"{tag}\". Please create one for the TilemapManager.");
        if (m_gridLayout is null)
            Debug.LogError("Cannot find grid layout.");
    }

    /// <summary>
    /// Sets the tile at the world position to the provided sprite.
    /// </summary>
    /// <param name="position">The world position of the tile</param>
    /// <param name="sprite">Sprite to set the tile to</param>
    /// <param name="overrideTile">Optional. When false, the tile will not be set if it is already set to a sprite</param>
    public void SetTile(Vector2Int position, Sprite sprite, bool overrideTile = true)
    {
        if (!overrideTile && TileIsSet(position)) return;

        Tile tile = ScriptableObject.CreateInstance<Tile>();
        tile.sprite = sprite;
        m_tilemap.SetTile((Vector3Int)position, tile);
        m_setTiles[position] = sprite;
    }

    /// <summary>
    /// </summary>
    /// <param name="position">World position of the tile</param>
    /// <returns>True if the tile is set to some sprite, false otherwise</returns>
    public bool TileIsSet(Vector2Int position)
    {
        return m_setTiles.ContainsKey(position) && m_setTiles[position] != null;
    }

    /// <summary>
    /// </summary>
    /// <param name="position">World position of the tile</param>
    /// <param name="sprite">Sprite to compare against the tile's sprite</param>
    /// <returns>True if the tile is set to the provided sprite, false otherwise</returns>
    public bool TileIsSetToSprite(Vector2Int position, Sprite sprite)
    {
        return TileIsSet(position) && m_setTiles[position] == sprite;
    }

    /// <summary>
    /// Clears the tile at the provided world position
    /// </summary>
    /// <param name="position">World position of the tile</param>
    public void ClearTile(Vector2Int position)
    {
        if (!TileIsSet(position)) return;

        Tile tile = ScriptableObject.CreateInstance<Tile>();
        m_tilemap.SetTile((Vector3Int)position, tile);
        m_setTiles.Remove(position);
    }

    /// <summary>
    /// Clears all the tiles in the tilemap that have been set
    /// </summary>
    public void ClearAllTiles()
    {
        foreach (Vector2Int position in m_setTiles.Keys)
        {
            ClearTile(position);
        }
    }

    /// <summary>
    /// Clears the provided sprite from all set tiles in the tilemap
    /// </summary>
    /// <param name="sprite">Sprite to clear from all tiles</param>
    public void ClearSpriteFromAllTiles(Sprite sprite)
    {
        foreach (Vector2Int position in m_setTiles.Keys)
        {
            if (TileIsSetToSprite(position, sprite))
            {
                ClearTile(position);
            }
        }
    }
}