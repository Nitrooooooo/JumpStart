using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

		public static bool QuickStackDepositMode => Instance.quickStackDepositMode;

		[JsonIgnore]
		public static bool ClearSearchText => Instance.clearSearchText;

		[JsonIgnore]
		public static bool ExtraFilterIcons => Instance.extraFilterIcons;

		[JsonIgnore]
		public static bool UseOldCraftMenu => Instance.useOldCraftMenu;

		[JsonIgnore]
		public static bool ItemDataDebug => Instance.itemDataDebug;

		[JsonIgnore]
		public static bool SearchBarRefreshOnKey => Instance.searchBarRefreshOnKey;

		[JsonIgnore]using Terraria.ModLoader.Config;

namespace JumpStart
{
    [Label("Jump Start Config")]
    public class JumpStartConfig : ModConfig
    {
        [Label("Armor Level")]
        [Tooltip("The level of the armor in the bag")]
        [DefaultListValue[]]

        public static JumpStartConfig Instance => ModContent.GetInstance<JumpStartConfig>();

        public override ConfigScope Mode => ConfigScope.ServerSide;
    }
}
