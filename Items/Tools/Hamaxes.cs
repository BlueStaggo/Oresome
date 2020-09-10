using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Oresome.Items.Tools
{	
	// BRONZE
	
	public class BronzeHamaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 8;
			item.melee = true;
			item.width = 50;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 36;
			item.axe = 15;
			item.hammer = 55;
			item.useStyle = 1;
			item.knockBack = 5.5f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.BronzeBar>(), 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// STEEL
	
	public class SteelHamaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 9;
			item.melee = true;
			item.width = 50;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 36;
			item.axe = 15;
			item.hammer = 55;
			item.useStyle = 1;
			item.knockBack = 5.5f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.SteelBar>(), 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// OSMITE
	
	public class OsmiteHamaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 10;
			item.melee = true;
			item.width = 50;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 36;
			item.axe = 15;
			item.hammer = 55;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.OsmiteBar>(), 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// IRIDIUM
	
	public class IridiumHamaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 11;
			item.melee = true;
			item.width = 50;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 36;
			item.axe = 15;
			item.hammer = 55;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.IridiumBar>(), 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}