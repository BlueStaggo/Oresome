using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Oresome.Items.Weapons
{
	public class SteelMissile : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Shoot magic bullets that pierce through your enemies");
		}
		
		public override void SetDefaults() {
			item.damage = 20;
			item.magic = true;
			item.mana = 8;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = true;
			item.channel = true;
			item.knockBack = 8;
			item.value = Item.sellPrice(silver : 50);
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.shoot = ProjectileID.GreenLaser;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.SteelBar>(), 12);
			recipe.AddIngredient(ItemID.WandofSparking);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}