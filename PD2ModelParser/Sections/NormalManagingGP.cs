using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD2ModelParser.Sections
{

	[ModelFileSection(Tags.normalManaging_tag)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class NormalManagingGP : GPBase, ISection, IPostLoadable
	{
		public NormalManagingGP(BinaryReader instream, SectionHeader section)
		{
			PostLoadRef<Geometry>(instream.ReadUInt32(), i => this.Geometry = i);
			PostLoadRef<Topology>(instream.ReadUInt32(), i => this.Topology = i);
			this.remaining_data = null;
		}
		public override void StreamWriteData(BinaryWriter outstream)
		{
			outstream.Write(this.Geometry.SectionId);
			outstream.Write(this.Topology.SectionId);
		}
	}
}
