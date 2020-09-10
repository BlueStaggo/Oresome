using Terraria.ID;
using Terraria.ModLoader;

namespace Oresome
{
	public class Oresome : Mod
	{
		// RECIPES
		
		public override void AddRecipes() {
			
			// AUTOHAMMER
			
			ModRecipe autohammer = new ModRecipe(this);
			autohammer.AddIngredient(ItemID.SilverBar, 6);
			autohammer.AddIngredient(ItemID.TungstenBar, 6);
			autohammer.AddIngredient(ItemID.Chain, 5);
			autohammer.AddTile(TileID.Anvils);
			autohammer.SetResult(ItemID.Autohammer);
			autohammer.AddRecipe();
		}
	}
}