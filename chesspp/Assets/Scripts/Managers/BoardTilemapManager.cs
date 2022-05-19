using System;
using System.Collections;
using UnityEngine;

public static class BoardTilemapManager
{
    private static TilemapManager m_tilemapManager;

    static BoardTilemapManager()
    {
        m_tilemapManager = new TilemapManager("PieceTilemap");
        Update();
    }

    /// This is just so the static constructor gets called
    public static void Start() { }

    public static void Update()
    {
        Sprite black = SpriteUtil.Black();
        Sprite white = SpriteUtil.White();
        for (int rank = (int)Position.Rank.I; rank <= (int)Position.Rank.VIII; rank++)
        {
            for (int file = (int)Position.File.A; file <= (int)Position.File.H; file++)
            {
                Vector2Int position = Position.BoardToWorld((Position.Rank)rank, (Position.File)file);
                if ((rank + file) % 2 == 0) m_tilemapManager.SetTile(position, black);
                else m_tilemapManager.SetTile(position, white);
            }
        }
    }
}