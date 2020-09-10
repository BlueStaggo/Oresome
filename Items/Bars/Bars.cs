using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Oresome.Items.Bars
{
	
	// BRONZE
	
	public class BronzeBar : ModItem
	{
		public override void SetDefaults() {
			item.value = Item.sellPrice(silver: 3);
			item.rare = 2;
			item.maxStack = 999;
			item.material = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 1);
			recipe.AddIngredient(ItemID.TinBar, 1);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
	
	// STEEL
	
	public class SteelBar : ModItem
	{
		public override void SetDefaults() {
			item.value = Item.sellPrice(silver: 3);
			item.rare = 2;
			item.maxStack = 999;
			item.material = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.LeadBar, 1);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
	
	// OSMITE
	
	public class OsmiteBar : ModItem
	{
		public override void SetDefaults() {
			item.value = Item.sellPrice(silver: 3);
			item.rare = 2;
			item.maxStack = 999;
			item.material = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 1);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
	
	// IRIDIUM
	
	public class IridiumBar : ModItem
	{
		public override void SetDefaults() {
			item.value = Item.sellPrice(silver: 3);
			item.rare = 2;
			item.maxStack = 999;
			item.material = true;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}