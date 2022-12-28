using JumpStart.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JumpStart
{
    public class InventoryPlayer : ModPlayer 
    {
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            if (mediumCoreDeath)
            {
                return new[] {
                    new Item(ItemID.HealingPotion)
                };
            }

            return new[] {
                new Item(ModContent.ItemType<StarterBag>())
            };
        }

    }
}
