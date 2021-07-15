namespace SRTPluginUIRE2DirectXOverlay
{
    public class PluginConfiguration
    {
        public bool Debug { get; set; }
        public bool NoInventory { get; set; }
        public bool ShowHPBars { get; set; }
        public bool ShowDamagedEnemiesOnly { get; set; }
        public bool ShowDifficultyAdjustment { get; set; }
        public float ScalingFactor { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public float EnemyHPPositionX { get; set; }
        public float EnemyHPPositionY { get; set; }

        public float InventoryPositionX { get; set; }
        public float InventoryPositionY { get; set; }

        public string StringFontName { get; set; }
        public string RankString { get; set; }
        public string ScoreString { get; set; }
        public string EnemyString { get; set; }

        public PluginConfiguration()
        {
            Debug = false;
            NoInventory = true;
            ShowHPBars = true;
            ShowDamagedEnemiesOnly = false;
            ShowDifficultyAdjustment = true;
            ScalingFactor = 1f;
            PositionX = 5f;
            PositionY = 50f;
            EnemyHPPositionX = -1;
            EnemyHPPositionY = -1;
            InventoryPositionX = -1;
            InventoryPositionY = -1;
            StringFontName = "Courier New";
            RankString = "DA RANK:";
            ScoreString = "DA SCORE:";
            EnemyString = "ENEMY HP";
        }
    }
}
