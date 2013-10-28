﻿namespace OrcaMDF.RawCore.Records
{
	public enum RawRecordType : byte
	{
		Primary = 0,
		Forwarded = 1,
		ForwardingStub = 2,
		Index = 3,
		BlobFragment = 4,
		GhostIndex = 5,
		GhostData = 6,
		GhostVersion = 7
	}
}