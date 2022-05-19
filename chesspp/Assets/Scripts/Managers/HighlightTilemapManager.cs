public static class HighlightTilemapManager
{
    private static TilemapManager m_tilemapManager;

    static HighlightTilemapManager()
    {
        m_tilemapManager = new TilemapManager("HighlightTilemap");
    }

    /// This is just so the static constructor gets called
    public static void Start() { }

    public static void Update() { }
}