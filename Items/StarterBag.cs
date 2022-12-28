using Terraria.GameContent.ItemDropRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Default;

namespace JumpStart.Items
{
    public class StarterBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starter Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}"); // References a language key that says "Right Click To Open" in the language of the game

            ItemID.Sets.BossBag[Type] = true; // This set is one that every boss bag should have, it, for example, lets our boss bag drop dev armor..
            ItemID.Sets.PreHardmodeLikeBossBag[Type] = true; // ..But this set ensures that dev armor will only be dropped on special world seeds, since that's the behavior of pre-hardmode boss bags.

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Purple;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            //Tools
            itemLoot.Add(ItemDropRule.Common(ItemID.IronBroadsword));
            itemLoot.Add(ItemDropRule.Common(ItemID.IronBow));
            itemLoot.Add(ItemDropRule.Common(ItemID.IronPickaxe));
            itemLoot.Add(ItemDropRule.Common(ItemID.IronAxe));

            //Armor
            itemLoot.Add(ItemDropRule.Common(ItemID.IronHelmet));
            itemLoot.Add(ItemDropRule.Common(ItemID.IronChainmail));
            itemLoot.Add(ItemDropRule.Common(ItemID.IronGreaves));

            //Equips
            itemLoot.Add(ItemDropRule.Common(ItemID.HermesBoots));
            itemLoot.Add(ItemDropRule.Common(ItemID.CloudinaBottle));

            //Random Stuff
            itemLoot.Add(ItemDropRule.Common(ItemID.LifeCrystal, 1, 5, 5));
            itemLoot.Add(ItemDropRule.Common(ItemID.ManaCrystal, 1, 5, 5));
            itemLoot.Add(ItemDropRule.Common(ItemID.WoodenArrow, 1, 150, 150));

            //Mod Content
            ModLoader.TryGetMod("MagicStorage", out Mod MagicStorage);
            if (MagicStorage != null)
            {
                if (MagicStorage.TryFind<ModItem>("StorageHeart", out ModItem StorageHeart)) { itemLoot.Add(ItemDropRule.Common(StorageHeart.Type)); }
                if (MagicStorage.TryFind<ModItem>("CraftingAccess", out ModItem CraftingAccess)) { itemLoot.Add(ItemDropRule.Common(CraftingAccess.Type)); }
                if (MagicStorage.TryFind<ModItem>("StorageUnit", out ModItem StorageUnit)) { itemLoot.Add(ItemDropRule.Common(StorageUnit.Type, 1, 16, 16)); }
            }
        }
    }
}
