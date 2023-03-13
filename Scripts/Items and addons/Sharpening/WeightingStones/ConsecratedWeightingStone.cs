using System;
using Server;
using Server.Targeting;

namespace Server.Items
{
	public class ConsecratedWeightingStone : Item
	{
		private int i_Uses;
		[CommandProperty( AccessLevel.GameMaster )]
		public int Uses { get { return i_Uses; } set { i_Uses = value; InvalidateProperties(); } }

		[Constructable] 
		public ConsecratedWeightingStone() : this( 5 )
		{
		}

		[Constructable] 
		public ConsecratedWeightingStone( int uses ) : base( 0x1F14 ) 
		{ 
			Weight = 1.0;
			i_Uses = uses;
			Hue = 0x38C;
			Name = "Consecrated Weighting Stone";
		} 

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060584, i_Uses.ToString() ); // uses remaining: ~1_val~
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) )
			{
				if ( Uses < 1 )
				{
					Delete();
					from.SendMessage(32, "This have no charges so it's gone!!!");
				}
				from.SendMessage("Which weapon you want to try to Weight?");
				from.Target = new ConsecratedWeightingStoneTarget(this);
			}
			else
				from.SendMessage("This must be in your backpack to use.");
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Can Increase A Mace/Puglist Glove/Stave's Damage");
			//list.Add( 1049644, "Will Not Bless The Weapon"); // PARENTHESIS
        }

		public void Weighting(Mobile from, object o)
		{
			if ( o is Item )
			{
				if ( !((Item)o).IsChildOf( from.Backpack ) )
				{
					from.SendMessage(32, "This must be in your backpack to Weight");
				}
				else if (o is BaseBashing && ((BaseBashing)o).IsChildOf(from.Backpack))
				{
					BaseBashing weap = o as BaseBashing;
					int i_DI = weap.Attributes.WeaponDamage;
					if (weap.Quality == WeaponQuality.Exceptional)
						i_DI += 15;
					if (i_DI >= 70)
					{
						from.SendMessage(32, "This weapon cannot be Weighted any further");
						return;
					}
					else if (from.Skills[SkillName.Blacksmith].Value < 100.0)
						from.SendMessage(32, "You need at least 100.0 blacksmith and 80.0 chivalry to Weight weapons with this stone");
					else if (from.Skills[SkillName.Chivalry].Value < 80.0)
						from.SendMessage(32, "You need at least 100.0 blacksmith and 80 chivalry to Weight weapons with this stone");
					else if ( !Deleted )
					{
						int bonus = Utility.Random((int)(from.Skills[SkillName.Blacksmith].Value/10));
						if (bonus > 0)
						{
							if (70 < i_DI + bonus)
								bonus = 70 - i_DI;
							weap.Attributes.WeaponDamage += bonus;
							weap.Consecrated = true;
							//weap.LootType = LootType.Blessed;
							from.SendMessage(88, "You Weighted the weapon with {0} damange increase", bonus);
						}
						else
							from.SendMessage(32, "You fail to Weight the weapon");
						if (Uses <= 1)
						{
							from.SendMessage(32, "You used up the Weighting stone");
							Delete();
						}
						else
						{
							--Uses;
							from.SendMessage(32, "You have {0} uses left", Uses);
						}
					}
				}
				else if (o is PugilistGlove && ((PugilistGlove)o).IsChildOf(from.Backpack))
				{
                    PugilistGlove weap = o as PugilistGlove;
					int i_DI = weap.Attributes.WeaponDamage;
					if (weap.Quality == WeaponQuality.Exceptional)
						i_DI += 15;
					if (i_DI >= 70)
					{
						from.SendMessage(32, "This weapon cannot be Weighted any further");
						return;
					}
					else if (from.Skills[SkillName.Blacksmith].Value < 100.0)
						from.SendMessage(32, "You need at least 100.0 blacksmith and 80.0 chivalry to Weight weapons with this stone");
					else if (from.Skills[SkillName.Chivalry].Value < 80.0)
						from.SendMessage(32, "You need at least 100.0 blacksmith and 80 chivalry to Weight weapons with this stone");
					else if ( !Deleted )
					{
						int bonus = Utility.Random((int)(from.Skills[SkillName.Blacksmith].Value/10));
						if (bonus > 0)
						{
							if (70 < i_DI + bonus)
								bonus = 70 - i_DI;
							weap.Attributes.WeaponDamage += bonus;
							weap.Consecrated = true;
							//weap.LootType = LootType.Blessed;
							from.SendMessage(88, "You Weighted the weapon with {0} damange increase", bonus);
						}
						else
							from.SendMessage(32, "You fail to Weight the weapon");
						if (Uses <= 1)
						{
							from.SendMessage(32, "You used up the Weighting stone");
							Delete();
						}
						else
						{
							--Uses;
							from.SendMessage(32, "You have {0} uses left", Uses);
						}
					}
				}
				else if (o is BaseStaff && ((BaseStaff)o).IsChildOf(from.Backpack))
				{
					BaseStaff weap = o as BaseStaff;
					int i_DI = weap.Attributes.WeaponDamage;
					if (weap.Quality == WeaponQuality.Exceptional)
						i_DI += 15;
					if (i_DI >= 70)
					{
						from.SendMessage(32, "This weapon cannot be Weighted any further");
						return;
					}
					else if (from.Skills[SkillName.Blacksmith].Value < 100.0)
						from.SendMessage(32, "You need at least 100.0 blacksmith and 80.0 chivalry to Weight weapons with this stone");
					else if (from.Skills[SkillName.Chivalry].Value < 80.0)
						from.SendMessage(32, "You need at least 100.0 blacksmith and 80 chivalry to Weight weapons with this stone");
					else if ( !Deleted )
					{
						int bonus = Utility.Random((int)(from.Skills[SkillName.Blacksmith].Value/10));
						if (bonus > 0)
						{
							if (70 < i_DI + bonus)
								bonus = 70 - i_DI;
							weap.Attributes.WeaponDamage += bonus;
							weap.Consecrated = true;
							//weap.LootType = LootType.Blessed;
							from.SendMessage(88, "You Weighted the weapon with {0} damange increase", bonus);
						}
						else
							from.SendMessage(32, "You fail to Weight the weapon");
						if (Uses <= 1)
						{
							from.SendMessage(32, "You used up the Weighting stone");
							Delete();
						}
						else
						{
							--Uses;
							from.SendMessage(32, "You have {0} uses left", Uses);
						}
					}
				}
				else
				{
					from.SendMessage(32, "You can only enhance edged weapons");
				}
			}
			else
			{
				from.SendMessage(32, "You can only enhance edged weapons");
			}
		}

		public ConsecratedWeightingStone( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

			writer.Write( (int) i_Uses );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			i_Uses = reader.ReadInt();
			if ( version == 0 ) { Serial sr_Owner = reader.ReadInt(); }
		}
	}

	public class ConsecratedWeightingStoneTarget : Target
	{
		private ConsecratedWeightingStone sb_Blade;

		public ConsecratedWeightingStoneTarget(ConsecratedWeightingStone blade) : base( 18, false, TargetFlags.None )
		{
			sb_Blade = blade;
		}

		protected override void OnTarget(Mobile from, object targeted)
		{
			if (sb_Blade.Deleted)
				return;

			sb_Blade.Weighting(from, targeted);
		}
	}
}