using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Oresome
{
	public class OresomePlayer : ModPlayer
	{
		private bool debug = false; // Toggle debug features
		
		public bool kryptoniteSetBonus; // Kryptonite armor's set bonus

		public override void ResetEffects() {
			kryptoniteSetBonus = false;
		}
		
		public override void PostUpdate() {
			if (debug) { // Debugging features
				Console.WriteLine("lifeRegen = "
					+ Convert.ToString(player.lifeRegen)
					+ " lifeRegenTime = "
					+ Convert.ToString(player.lifeRegenTime)
					+ " lifeRegenCount = "
					+ Convert.ToString(player.lifeRegenCount)); // Display lifeRegen, lifeRegenTime and lifeRegenCount in the console
			}
		}
		
		public override void UpdateLifeRegen() {
			if (kryptoniteSetBonus) { // Kryptonite armor's set bonus
				player.lifeRegenTime += 2;
				if (player.lifeRegenTime < 300) {
					player.lifeRegen += 0;
				} else if (player.lifeRegenTime < 900) {
					player.lifeRegen += 1;
				} else if (player.lifeRegenTime < 1500) {
					player.lifeRegen += 2;
				} else if (player.lifeRegenTime < 2400) {
					player.lifeRegen += 3;
				} else if (player.lifeRegenTime >= 2400) {
					player.lifeRegen += 4;
				}
				
				/* lifeRegen values
				
				lifeRegen += 0 (0 - 299)
				lifeRegen += 1 (300 - 899)
				lifeRegen += 2 (900 - 1499)
				lifeRegen += 3 (1500 - 2399)
				lifeRegen += 4 (2400+)
				
				*/
			}
		}
	}
}
