
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
	public class BathroomAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3247, -2, 1, 0}, {3254, 3, 3, 0}, {3253, 3, 6, 0}// 1	 2	 3	 
			, {3247, 5, -6, 0}, {1295, -2, 0, 0}, {1295, -2, 1, 0}// 4	 5	6	
			, {1295, -2, 2, 0}, {1295, -2, 3, 0}, {1295, -2, 4, 0}// 7	8	9	
			, {1295, -2, 5, 0}, {1295, -1, 0, 0}, {1295, -1, 1, 0}// 10	11	12	
			, {1295, -1, 2, 0}, {1295, -1, 3, 0}, {1295, -1, 4, 0}// 13	14	15	
			, {1295, -1, 5, 0}, {1295, 0, 0, 0}, {1295, 0, 1, 0}// 16	17	18	
			, {1295, 0, 2, 0}, {1295, 0, 3, 0}, {1295, 0, 4, 0}// 19	20	21	
			, {1295, 0, 5, 0}, {1295, 1, -4, 0}, {1295, 1, -3, 0}// 22	23	24	
			, {1295, 1, -2, 0}, {1295, 1, -1, 0}, {1295, 1, 0, 0}// 25	26	27	
			, {1295, 1, 1, 0}, {1295, 1, 2, 0}, {1295, 1, 3, 0}// 28	29	30	
			, {1295, 1, 4, 0}, {1295, 1, 5, 0}, {1293, -2, -4, 0}// 31	32	33	
			, {1293, -2, -3, 0}, {1293, -2, -2, 0}, {1293, -1, -4, 0}// 34	35	36	
			, {1293, -1, -3, 0}, {1293, -1, -2, 0}, {1293, 0, -4, 0}// 37	38	39	
			, {1293, 0, -3, 0}, {1293, 0, -2, 0}, {1295, -2, -1, 0}// 40	41	42	
			, {1295, -1, -1, 0}, {1295, 0, -1, 0}, {515, 1, -5, 0}// 43	44	52	
			, {511, -3, -1, 0}, {516, -4, 0, 0}, {516, -4, 1, 0}// 53	54	55	
			, {516, -4, 2, 0}, {516, -4, 3, 0}, {516, -4, 4, 0}// 56	57	58	
			, {516, -4, 5, 0}, {515, -3, 5, 0}, {515, -2, 5, 0}// 59	60	61	
			, {515, -1, 5, 0}, {515, 0, 5, 0}, {515, 1, 5, 0}// 62	63	64	
			, {514, -4, -1, 0}, {1295, -3, 0, 0}, {1295, -3, 1, 0}// 65	66	67	
			, {1295, -3, 2, 0}, {1295, -3, 3, 0}, {1295, -3, 4, 0}// 68	69	70	
			, {1295, -3, 5, 0}, {12511, -3, 0, 0}, {12512, -3, 1, 0}// 71	74	75	
			, {1295, 2, -4, 0}, {1295, 2, -3, 0}, {1295, 2, -2, 0}// 95	96	97	
			, {1295, 2, -1, 0}, {1295, 2, 0, 0}, {1295, 2, 1, 0}// 98	99	100	
			, {1295, 2, 2, 0}, {1295, 2, 3, 0}, {1295, 2, 4, 0}// 101	102	103	
			, {1295, 2, 5, 0}, {1295, 3, -4, 0}, {1295, 3, -3, 0}// 104	105	106	
			, {1295, 3, -2, 0}, {1295, 3, -1, 0}, {1295, 3, 0, 0}// 107	108	109	
			, {1295, 3, 1, 0}, {1295, 3, 2, 0}, {1295, 3, 3, 0}// 110	111	112	
			, {1295, 3, 4, 0}, {1295, 3, 5, 0}, {1295, 4, -4, 0}// 113	114	115	
			, {1295, 4, -3, 0}, {1295, 4, -2, 0}, {1295, 4, -1, 0}// 116	117	118	
			, {1295, 4, 0, 0}, {1295, 4, 1, 0}, {1295, 4, 2, 0}// 119	120	121	
			, {1295, 4, 3, 0}, {1295, 4, 4, 0}, {516, 4, -4, 0}// 122	123	124	
			, {516, 4, -3, 0}, {516, 4, -2, 0}, {516, 4, -1, 0}// 125	126	127	
			, {516, 4, 2, 0}, {516, 4, 3, 0}, {516, 4, 4, 0}// 128	129	130	
			, {515, 3, 5, 0}, {511, 4, 5, 0}, {515, 2, -5, 0}// 131	132	133	
			, {515, 3, -5, 0}, {515, 4, -5, 0}, {1295, 4, 5, 0}// 134	135	136	
			, {515, 2, 5, 0}// 137	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BathroomAddonDeed();
			}
		}

		[ Constructable ]
		public BathroomAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 250, -3, -4, 0, 1160, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 250, -3, -3, 0, 1160, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 250, -3, -2, 0, 1160, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 249, -2, -5, 0, 1160, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 249, -1, -5, 0, 1160, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 249, 0, -5, 0, 1160, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 251, -3, -5, 0, 1160, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 4832, 1, -3, 0, 1172, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 4843, -1, -1, 0, 1172, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 3707, 1, 3, 2, 0, -1, "Toilet", 1);// 76
			AddComplexComponent( (BaseAddon) this, 2913, -2, -3, 10, 2407, -1, "Shower Shelf", 1);// 77
			AddComplexComponent( (BaseAddon) this, 6197, -1, -4, 15, 0, -1, "Shower Head", 1);// 78
			AddComplexComponent( (BaseAddon) this, 3626, -2, -3, 11, 0, -1, "Shampoo", 1);// 79
			AddComplexComponent( (BaseAddon) this, 5154, -2, -3, 11, 0, -1, "Soap", 1);// 80
			AddComplexComponent( (BaseAddon) this, 5534, -3, 2, 0, 1170, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 5534, -3, 4, 0, 1170, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 5534, -3, 3, 0, 1170, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 251, 0, -2, 0, 1160, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 2486, -1, -4, 0, 2105, -1, "Drain", 1);// 85
			AddComplexComponent( (BaseAddon) this, 2755, -1, -1, 0, 1170, -1, "Bath Mat", 1);// 86
			AddComplexComponent( (BaseAddon) this, 2756, -1, 1, 0, 1170, -1, "Bath Mat", 1);// 87
			AddComplexComponent( (BaseAddon) this, 2757, 1, -1, 0, 1170, -1, "Bath Mat", 1);// 88
			AddComplexComponent( (BaseAddon) this, 2754, 1, 1, 0, 1170, -1, "Bath Mat", 1);// 89
			AddComplexComponent( (BaseAddon) this, 2806, -1, 0, 0, 1170, -1, "Bath Mat", 1);// 90
			AddComplexComponent( (BaseAddon) this, 2807, 0, -1, 0, 1170, -1, "Bath Mat", 1);// 91
			AddComplexComponent( (BaseAddon) this, 2808, 1, 0, 0, 1170, -1, "Bath Mat", 1);// 92
			AddComplexComponent( (BaseAddon) this, 2809, 0, 1, 0, 1170, -1, "Bath Mat", 1);// 93
			AddComplexComponent( (BaseAddon) this, 2749, 0, 0, 0, 1170, -1, "Bath Mat", 1);// 94
			AddComplexComponent( (BaseAddon) this, 3673, 2, 3, 0, 0, -1, "Toilet", 1);// 138
			AddComplexComponent( (BaseAddon) this, 4015, 2, 3, 7, 1511, -1, "Toilet", 1);// 139

		}

		public BathroomAddon( Serial serial ) : base( serial )
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

	public class BathroomAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BathroomAddon();
			}
		}

		[Constructable]
		public BathroomAddonDeed()
		{
			Name = "Bathroom";
		}

		public BathroomAddonDeed( Serial serial ) : base( serial )
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
