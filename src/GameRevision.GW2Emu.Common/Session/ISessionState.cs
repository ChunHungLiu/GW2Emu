using System;
using System.Collections.Generic;
using GameRevision.GW2Emu.Common.Messaging;

namespace GameRevision.GW2Emu.Common.Session
{
	public interface ISessionState
	{
		IEnumerable<IMessage> Deserialize(ISession session, byte[] buffer, int dataLen);

        byte[] Serialize(ISession session, IMessage message);
	}
}

