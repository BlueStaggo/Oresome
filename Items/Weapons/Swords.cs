using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Oresome.Items.Weapons
{
	// BRONZE
	
	public class BronzeSword : ModItem
	{
		public override void SetDefaults() {
			item.damage = 12;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(silver: 2, copper: 70);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Bars.BronzeBar>(), 8);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// STEEL
	
	public class SteelSword : ModItem
	{
		public override void SetDefaults() {
			item.damage = 13;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(silver: 2, copper: 70);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Bars.SteelBar>(), 8);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// OSMITE
	
	public class OsmiteSword : ModItem
	{
		public override void SetDefaults() {
			item.damage = 14;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6.5f;
			item.value = Item.sellPrice(silver: 2, copper: 70);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Bars.OsmiteBar>(), 8);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// IRIDIUM
	
	public class IridiumSword : ModItem
	{
		public override void SetDefaults() {
			item.damage = 16;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6.5f;
			item.value = Item.sellPrice(silver: 2, copper: 70);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Bars.IridiumBar>(), 8);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// IRIDIUM CLAYMORE
	
	public class IridiumClaymore : ModItem
	{
		public override void SetDefaults() {
			item.damage = 19;
			item.melee = true;
			item.width = 68;
			item.height = 68;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 6.5f;
			item.value = Item.sellPrice(silver: 2, copper: 70);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.crit = -4;
			item.shoot = ProjectileID.TerraBeam;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Bars.IridiumBar>(), 16);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}