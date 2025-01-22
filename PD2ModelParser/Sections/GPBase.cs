using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD2ModelParser.Sections
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class GPBase : AbstractSection
	{
		[Category("Geometry Producer")]
		public Geometry Geometry { get; set; }
		[Category("Geometry Producer")]
		public Topology Topology { get; set; }
		public byte[] remaining_data = null;

		public override void StreamWriteData(BinaryWriter output)
		{
			throw new NotImplementedException();
		}
	}
}
