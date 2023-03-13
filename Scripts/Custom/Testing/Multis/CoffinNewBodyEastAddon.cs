
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CoffinNewBodyEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3937, 1, 1, 2}// 22	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CoffinNewBodyEastAddonDeed();
			}
		}

		[ Constructable ]
		public CoffinNewBodyEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7220, 0, 2, 0, 1102, -1, "Coffin", 1);// 1
			AddComplexComponent( (BaseAddon) this, 7221, 1, 2, 0, 1102, -1, "Coffin", 1);// 2
			AddComplexComponent( (BaseAddon) this, 7222, 1, 1, 0, 1102, -1, "Coffin", 1);// 3
			AddComplexComponent( (BaseAddon) this, 7222, 1, 0, 0, 1102, -1, "Coffin", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7223, 1, -1, 0, 1102, -1, "Coffin", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7227, 0, 2, 0, 1102, -1, "Coffin", 1);// 6
			AddComplexComponent( (BaseAddon) this, 7219, 1, 2, 13, 1106, -1, "Coffin", 1);// 7
			AddComplexComponent( (BaseAddon) this, 7219, 0, -1, 0, 1103, -1, "Coffin", 1);// 8
			AddComplexComponent( (BaseAddon) this, 7219, 0, 0, 0, 1103, -1, "Coffin", 1);// 9
			AddComplexComponent( (BaseAddon) this, 7216, 1, 0, 12, 1106, -1, "Coffin", 1);// 10
			AddComplexComponent( (BaseAddon) this, 7216, 1, 1, 12, 1106, -1, "Coffin", 1);// 11
			AddComplexComponent( (BaseAddon) this, 7216, 1, 2, 12, 1106, -1, "Coffin", 1);// 12
			AddComplexComponent( (BaseAddon) this, 7219, 1, 0, 13, 1106, -1, "Coffin", 1);// 13
			AddComplexComponent( (BaseAddon) this, 7219, 1, 1, 13, 1106, -1, "Coffin", 1);// 14
			AddComplexComponent( (BaseAddon) this, 7219, 1, 2, 11, 1103, -1, "Coffin", 1);// 15
			AddComplexComponent( (BaseAddon) this, 7218, 0, 1, 2, 1103, -1, "Coffin", 1);// 16
			AddComplexComponent( (BaseAddon) this, 7565, 1, 1, 4, 0, -1, "Mummy", 1);// 17
			AddComplexComponent( (BaseAddon) this, 7944, 1, 2, 4, 1150, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 7946, 1, 1, 2, 1150, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 15285, 1, 2, 5, 0, -1, "Ankh Pendant", 1);// 20
			AddComplexComponent( (BaseAddon) this, 7341, 1, 0, 4, 0, -1, "Mummy", 1);// 21

		}

		public CoffinNewBodyEastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CoffinNewBodyEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CoffinNewBodyEastAddon();
			}
		}

		[Constructable]
		public CoffinNewBodyEastAddonDeed()
		{
			Name = "CoffinNewBodyEast";
		}

		public CoffinNewBodyEastAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}