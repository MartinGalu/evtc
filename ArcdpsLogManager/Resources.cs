using System.IO;
using System.Reflection;
using Eto.Drawing;

namespace GW2Scratch.ArcdpsLogManager
{
	public static class Resources
	{
		private const string ImageDirectoryName = "Images";

		private static string GetImagePath(string imageName)
		{
			return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ImageDirectoryName,
				imageName);
		}

		private static Bitmap GetImage(string imageName)
		{
			return new Bitmap(GetImagePath(imageName));
		}

		public static Icon GetProgramIcon()
		{
			//This fixes the program icon not showing up on windows, requires testing on Linux and Mac
			return new Icon(GetImagePath("program_icon.png"));
			//return new Icon(1, GetImage("program_icon.png"));
		}

		public static Image GetTinyIconWarrior()
		{
			return GetImage("Tango/Warrior_tango_icon_20px.png");
		}

		public static Image GetTinyIconGuardian()
		{
			return GetImage("Tango/Guardian_tango_icon_20px.png");
		}

		public static Image GetTinyIconRevenant()
		{
			return GetImage("Tango/Revenant_tango_icon_20px.png");
		}

		public static Image GetTinyIconRanger()
		{
			return GetImage("Tango/Ranger_tango_icon_20px.png");
		}

		public static Image GetTinyIconThief()
		{
			return GetImage("Tango/Thief_tango_icon_20px.png");
		}

		public static Image GetTinyIconEngineer()
		{
			return GetImage("Tango/Engineer_tango_icon_20px.png");
		}

		public static Image GetTinyIconNecromancer()
		{
			return GetImage("Tango/Necromancer_tango_icon_20px.png");
		}

		public static Image GetTinyIconElementalist()
		{
			return GetImage("Tango/Elementalist_tango_icon_20px.png");
		}

		public static Image GetTinyIconMesmer()
		{
			return GetImage("Tango/Mesmer_tango_icon_20px.png");
		}

		public static Image GetTinyIconBerserker()
		{
			return GetImage("Tango/Berserker_tango_icon_20px.png");
		}

		public static Image GetTinyIconSpellbreaker()
		{
			return GetImage("Tango/Spellbreaker_tango_icon_20px.png");
		}

		public static Image GetTinyIconDragonhunter()
		{
			return GetImage("Tango/Dragonhunter_tango_icon_20px.png");
		}

		public static Image GetTinyIconFirebrand()
		{
			return GetImage("Tango/Firebrand_tango_icon_20px.png");
		}

		public static Image GetTinyIconHerald()
		{
			return GetImage("Tango/Herald_tango_icon_20px.png");
		}

		public static Image GetTinyIconRenegade()
		{
			return GetImage("Tango/Renegade_tango_icon_20px.png");
		}

		public static Image GetTinyIconDruid()
		{
			return GetImage("Tango/Druid_tango_icon_20px.png");
		}

		public static Image GetTinyIconSoulbeast()
		{
			return GetImage("Tango/Soulbeast_tango_icon_20px.png");
		}

		public static Image GetTinyIconDaredevil()
		{
			return GetImage("Tango/Daredevil_tango_icon_20px.png");
		}

		public static Image GetTinyIconDeadeye()
		{
			return GetImage("Tango/Deadeye_tango_icon_20px.png");
		}

		public static Image GetTinyIconScrapper()
		{
			return GetImage("Tango/Scrapper_tango_icon_20px.png");
		}

		public static Image GetTinyIconHolosmith()
		{
			return GetImage("Tango/Holosmith_tango_icon_20px.png");
		}

		public static Image GetTinyIconReaper()
		{
			return GetImage("Tango/Reaper_tango_icon_20px.png");
		}

		public static Image GetTinyIconScourge()
		{
			return GetImage("Tango/Scourge_tango_icon_20px.png");
		}

		public static Image GetTinyIconTempest()
		{
			return GetImage("Tango/Tempest_tango_icon_20px.png");
		}

		public static Image GetTinyIconWeaver()
		{
			return GetImage("Tango/Weaver_tango_icon_20px.png");
		}

		public static Image GetTinyIconChronomancer()
		{
			return GetImage("Tango/Chronomancer_tango_icon_20px.png");
		}

		public static Image GetTinyIconMirage()
		{
			return GetImage("Tango/Mirage_tango_icon_20px.png");
		}

		public static Image GetTinyIconRaid()
		{
			return GetImage("ArenaNet/raid_icon_32px.png");
		}

		public static Image GetTinyIconFractals()
		{
			return GetImage("ArenaNet/fractals_icon_32px.png");
		}

		public static Image GetTinyIconGuildRegistrar()
		{
			return GetImage("ArenaNet/guild_registrar_icon_26px.png");
		}

		public static Image GetTinyIconCommander()
		{
			return GetImage("ArenaNet/commander_tag_red_32px.png");
		}

		public static Image GetTinyIconStrike()
		{
			return GetImage("ArenaNet/strike_icon_32px.png");
		}

		public static Image GetTinyIconTrainingArea()
		{
			return GetImage("ArenaNet/training_area_32px.png");
		}

		public static Image GetTinyIconWorldVersusWorld()
		{
			return GetImage("ArenaNet/world_vs_world_32px.png");
		}

		public static Image GetTinyIconUncategorized()
		{
			return GetImage("ArenaNet/uncategorized_32px.png");
		}
		public static Image GetTinyIconFestival()
		{
			return GetImage("ArenaNet/festivals_32px.png");
		}

		// Fractal Instabilities
		public static Image GetTinyIconAfflicted()
		{
			return GetImage("ArenaNet/fractal_instabilities/afflicted_32px.png");
		}

		public static Image GetTinyIconBirds()
		{
			return GetImage("ArenaNet/fractal_instabilities/birds_32px.png");
		}
		public static Image GetTinyIconBoonOverload()
		{
			return GetImage("ArenaNet/fractal_instabilities/boon_overload_32px.png");
		}
		public static Image GetTinyIconFluxBomb()
		{
			return GetImage("ArenaNet/fractal_instabilities/flux_bomb_32px.png");
		}
		public static Image GetTinyIconFractalVindicators()
		{
			return GetImage("ArenaNet/fractal_instabilities/fractal_vindicators_32px.png");
		}
		public static Image GetTinyIconFrailty()
		{
			return GetImage("ArenaNet/fractal_instabilities/frailty_32px.png");
		}
		public static Image GetTinyIconHamstrung()
		{
			return GetImage("ArenaNet/fractal_instabilities/hamstrung_32px.png");
		}
		public static Image GetTinyIconLastLaugh()
		{
			return GetImage("ArenaNet/fractal_instabilities/last_laugh_32px.png");
		}
		public static Image GetTinyIconMistsConvergence()
		{
			return GetImage("ArenaNet/fractal_instabilities/mists_convergence_32px.png");
		}
		public static Image GetTinyIconNoPainNoGain()
		{
			return GetImage("ArenaNet/fractal_instabilities/no_pain_no_gain_32px.png");
		}
		public static Image GetTinyIconOutflanked()
		{
			return GetImage("ArenaNet/fractal_instabilities/outflanked_32px.png");
		}
		public static Image GetTinyIconSlipperySlope()
		{
			return GetImage("ArenaNet/fractal_instabilities/slippery_slope_32px.png");
		}
		public static Image GetTinyIconSocialAwkwardness()
		{
			return GetImage("ArenaNet/fractal_instabilities/social_awkwardness_32px.png");
		}
		public static Image GetTinyIconStickTogether()
		{
			return GetImage("ArenaNet/fractal_instabilities/stick_together_32px.png");
		}
		public static Image GetTinyIconSugarRush()
		{
			return GetImage("ArenaNet/fractal_instabilities/sugar_rush_32px.png");
		}
		public static Image GetTinyIconToxicSickness()
		{
			return GetImage("ArenaNet/fractal_instabilities/toxic_sickness_32px.png");
		}
		public static Image GetTinyIconToxicTrail()
		{
			return GetImage("ArenaNet/fractal_instabilities/toxic_trail_32px.png");
		}
		public static Image GetTinyIconVengeance()
		{
			return GetImage("ArenaNet/fractal_instabilities/vengeance_32px.png");
		}
		public static Image GetTinyIconWeBleedFire()
		{
			return GetImage("ArenaNet/fractal_instabilities/we_bleed_fire_32px.png");
		}

		// End Fractal Instabilities
	}
}