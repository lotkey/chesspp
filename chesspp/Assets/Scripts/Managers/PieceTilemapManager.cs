public static class PieceTilemapManager
{
    private static TilemapManager m_tilemapManager;

    static PieceTilemapManager()
    {
        m_tilemapManager = new TilemapManager("PieceTilemap");
    }

    /// This is just so the static constructor gets called
    public static void Start() { }

    public static void Update() { }
}