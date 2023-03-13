using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server.Gumps;
using Server.OneTime;

namespace Server.Mobiles
{
	public class MidlandTinker : MidlandVendor
	{


		[Constructable]
		public MidlandTinker() : base(  )
		{
			Job = JobFragment.shopkeep;
			good1 = typeof(TinkerTools);
			good1name = "Tools";
			Title = "the tinker tool vendor";
			good1adjust = 2;
			
			((BaseCreature)this).midrace = 1;
		}

		public MidlandTinker( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			good1 = typeof(TinkerTools);

		}
	}
}