﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShock.Hooks;
using TShock.Hooks.Player;
using TShock.Hooks.NPC;

namespace TShock.Hooks
{
	/// <summary>
	/// Hooks interface
	/// </summary>
	public interface IHooks
	{
		PlayerHooks PlayerHooks { get; }
        NpcHooks NpcHooks { get; }
	}
}
