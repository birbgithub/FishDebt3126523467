using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items
{
    internal class FishSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Water");
            Tooltip.SetDefault("'The essence of water creatures'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;

            Main.RegisterItemAnimation(Items.type, new DrawAnimationVertical(5, 7));
            ItemID.Sets.AnimatesAsSoul[Items.type] = true;

            ItemID.Sets.ItemIconPulse[Items.type] = true;
            ItemID.Sets.ItemNoGravity[Items.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.sellPrice(gold: 1, silver: 24);
            Item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(520, 1) // Soul of Light
                .AddIngredient(521, 1) // Soul of Night
                .AddIngredient(261, 1) // Goldfish
                .AddTile(77)
                .Register();
        }
    }
}