using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Oresome.Items.Armor
{
	// BRONZE
	
	[AutoloadEquip(EquipType.Head)]
	public class BronzeHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases minion damage by 8%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<BronzeBreastplate>() && legs.type == ItemType<BronzeLeggings>();
		}
		
		public override void UpdateEquip(Player player) {
			player.minionDamage += 0.08f;
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Increases minion damage by 5%";
			player.minionDamage += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.BronzeBar>(), 15);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Body)]
	public class BronzeBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases your max number of minions by 1"
				+ "\nIncreases minion damage by 4%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.maxMinions++;
			player.minionDamage +=0.04f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.BronzeBar>(), 25);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Legs)]
	public class BronzeLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("5% increased movement speed");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.BronzeBar>(), 20);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// STEEL
	
	[AutoloadEquip(EquipType.Head)]
	public class SteelHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases maximum mana by 60");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<SteelBreastplate>() && legs.type == ItemType<SteelLeggings>();
		}
		
		public override void UpdateEquip(Player player) {
			player.statManaMax2 += 60;
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "10% reduced mana usage";
			player.manaCost -= 0.10f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.SteelBar>(), 15);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Body)]
	public class SteelBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases magic damage by 12%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player) {
			player.magicDamage += 0.12f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.SteelBar>(), 25);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Legs)]
	public class SteelLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("9% increased magic critical strike chance");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.magicCrit += 9;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.SteelBar>(), 20);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	
	// OSMITE
	
	[AutoloadEquip(EquipType.Head)]
	public class OsmiteHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases ranged damage by 3%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<OsmiteBreastplate>() && legs.type == ItemType<OsmiteLeggings>();
		}
		
		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.03f;
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Increases movement speed by 10%";
			player.moveSpeed += 0.15f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.OsmiteBar>(), 15);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Body)]
	public class OsmiteBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases ranged damage by 4%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.04f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.OsmiteBar>(), 25);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Legs)]
	public class OsmiteLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases ranged damage by 3%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.03f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.OsmiteBar>(), 20);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	// IRIDIUM
	
	[AutoloadEquip(EquipType.Head)]
	public class IridiumHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases melee damage by 4%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<IridiumBreastplate>() && legs.type == ItemType<IridiumLeggings>();
		}
		
		public override void UpdateEquip(Player player) {
			player.meleeDamage += 0.04f;
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Increases melee speed by 12%";
			player.meleeSpeed += 0.12f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.IridiumBar>(), 15);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Body)]
	public class IridiumBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases melee damage by 4%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player) {
			player.meleeDamage += 0.04f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.IridiumBar>(), 25);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	[AutoloadEquip(EquipType.Legs)]
	public class IridiumLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases melee damage by 4%");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player) {
			player.meleeDamage += 0.04f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Bars.IridiumBar>(), 20);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}