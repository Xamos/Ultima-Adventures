using System;
using Server;


namespace Server.Items
{
	public class BraceletOfTheElements : GoldBracelet
	{
		public override int LabelNumber{ get{ return 1061104; } } // Bracelet of the Elements


		[Constructable]
		public BraceletOfTheElements()
		{
			Name = "Bracelet of the Elements";
			Hue = 0x4E9;
			Attributes.Luck = 200;
			Resistances.Fire = 16;
			Resistances.Cold = 16;
			Resistances.Poison = 16;
			Resistances.Energy = 16;
		}


        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artifact");
        }


		public BraceletOfTheElements( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );


			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );


			int version = reader.ReadInt();
		}
	}
}