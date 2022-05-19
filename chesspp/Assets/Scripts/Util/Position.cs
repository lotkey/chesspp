using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Static class that has functions to handle all position functionality.  
/// Includes world positions, board positions, and array indices for the board.
/// </summary>
public static class Position
{
    /// <summary>
    /// Enum for the columns of the board. Can be cast to int to get the array index.
    /// </summary>
    public enum File : int
    {
        A = 0, B = 1, C = 2, D = 3, E = 4, F = 5, G = 6, H = 7
    }

    /// <summary>
    /// Enum for the rows of the board. Can be cast to int to get the array index.
    /// </summary>
    public enum Rank
    {
        I = 0, II = 1, III = 2, IV = 3, V = 4, VI = 5, VII = 6, VIII = 7
    }

    /// <summary>
    /// Converts from a position on the board to the position in the scene where that tile is.
    /// </summary>
    public static Vector2Int BoardToWorld(Rank rank, File file)
    {
        return new Vector2Int((int)rank - 4, (int)file - 4);
    }

    /// <summary>
    /// </summary>
    /// <param name="position">World position</param>
    /// <returns>True if the world position is on the board, false otherwise</returns>
    public static bool WordPositionIsOnBoard(Vector2Int position)
    {
        return position.x <= (int)Rank.VIII && position.x >= (int)Rank.I &&
            position.y <= (int)File.H && position.y >= (int)File.A;
    }

    /// <summary>
    /// Converts a world position to a board position and returns it
    /// </summary>
    /// <param name="position">World position to convert to board position</param>
    /// <returns>Tuple of rank and file describing the board position</returns>
    public static Tuple<Rank, File> WorldToBoard(Vector2Int position)
    {
        Rank rank = (Position.Rank)(position.x + 4);
        File file = (Position.File)(position.y + 4);
        return new Tuple<Rank, File>(rank, file);
    }
}