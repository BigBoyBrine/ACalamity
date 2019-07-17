using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria;
using Terraria.Audio;
using Terraria.ID;

namespace CashTooltip
{
	public class CashTooltip : Mod
	{
        public class bruh : GlobalNPC
        {
            public override void ResetEffects(NPC npc)
            {
                //Revengeance Mode 2
                base.ResetEffects(npc);
                npc.DeathSound = SoundID.DD2_BetsyScream;
                npc.HitSound = SoundID.DD2_BetsyScream;
                npc.life += 30000;
                npc.damage += npc.lifeMax + 20;
                npc.drippingSlime = true;
                // To whomever is looking in here, this is a practical joke. 
                // Contact me at lizardry?#3452 if you're a Calamity dev looking to get this removed
            }

        }


    }
}