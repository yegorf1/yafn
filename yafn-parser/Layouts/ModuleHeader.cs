﻿using System.IO;

namespace Yafn.Parser.Layouts  {
	public struct ModuleHeader : ISimpleLayout {
		public StringLayout signature;
		public int formatVersion;
		public int platformNameIndex;
		public int platformVersion;
		public long entryPoint;

		public void Read(BinaryReader reader) {
			signature.Read(reader);
			formatVersion = reader.ReadInt32();
			platformNameIndex = reader.ReadInt32();
			platformVersion = reader.ReadInt32();
			entryPoint = reader.ReadInt64();
		}

		public void Write(BinaryWriter writer) {
			signature.Write(writer);
			writer.Write(formatVersion);
			writer.Write(platformNameIndex);
			writer.Write(platformVersion);
			writer.Write(entryPoint);
		}
	}
}