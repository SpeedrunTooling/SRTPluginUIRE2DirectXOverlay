namespace SRTPluginUIRE2DirectXOverlay
{
    public class PluginConfiguration
    {
        public bool Debug { get; set; }
        public bool NoInventory { get; set; }
        public float ScalingFactor { get; set; }

        public PluginConfiguration()
        {
            Debug = false;
            NoInventory = false;
            ScalingFactor = 0.75f;
        }
    }
}
