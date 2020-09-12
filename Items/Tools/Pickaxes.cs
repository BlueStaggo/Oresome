using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Oresome.Items.Tools
{	
	// BRONZE
	
	public class BronzePickaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 6;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 20;
			item.pick = 64;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.BronzeBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// STEEL
	
	public class SteelPickaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 7;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 20;
			item.pick = 64;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.SteelBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// OSMITE
	
	public class OsmitePickaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 8;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 20;
			item.pick = 64;
			item.useStyle = 1;
			item.knockBack = 3.5f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.OsmiteBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// IRIDIUM
	
	public class IridiumPickaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 9;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 20;
			item.pick = 64;
			item.useStyle = 1;
			item.knockBack = 3.5f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.IridiumBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// KRYPTONITE
	
	public class KryptonitePickaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 11;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 13;
			item.useAnimation = 20;
			item.pick = 99;
			item.useStyle = 1;
			item.knockBack = 3.5f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.KryptoniteBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// ARGONITE
	
	public class ArgonitePickaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 12;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 13;
			item.useAnimation = 20;
			item.pick = 99;
			item.useStyle = 1;
			item.knockBack = 3.5f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Bars.ArgoniteBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}